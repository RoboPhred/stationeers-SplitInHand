
using Assets.Scripts;
using Assets.Scripts.Networking;
using Assets.Scripts.Objects;
using Assets.Scripts.Objects.Entities;
using Assets.Scripts.Objects.Items;
using HarmonyLib;
using UnityEngine;

namespace SplitInHand
{

    [HarmonyPatch(typeof(Stackable), "SplitStack")]
    class StackableSplitStackPatch
    {
        static bool Prefix(Stackable __instance, Interaction interaction, int quantity)
        {
            StackableSplitStackPatch.PatchedSplitStack(__instance, interaction, quantity);
            return false;
        }

        static void PatchedSplitStack(Stackable __instance, Interaction interaction, int quantity)
        {
            if (!GameManager.IsServer || quantity > __instance.Quantity)
                return;
            __instance.NetworkQuantity = __instance.Quantity - quantity;
            Human parent = interaction.SourceSlot.Parent as Human;
            if (parent == null)
                return;


            Stackable newStack = OnServer.Create(
                __instance.Prefab as DynamicThing,
                __instance.GetSafeDropPosition(
                    interaction.SourceSlot.Parent.CenterPosition,
                    parent.HelmetSlot.Location.forward,
                    interaction.SourceThing.Bounds.size.z + 0.6f
                ),
                interaction.SourceThing.ThingTransform.rotation,
                __instance.OwnerSteamId,
                __instance.GridController.ParentMothership != null ? __instance.GridController.ParentMothership.RigidBody : null
            ) as Stackable;

            if (newStack != null)
            {
                if (__instance.CustomColor.IsSet)
                    OnServer.SetCustomColor(newStack, __instance.CustomColor.Index);
                newStack.NetworkQuantity = Mathf.Min(quantity, newStack.MaxQuantity);
                __instance.OnSplitStack(newStack);
                Slot destinationSlot = parent.LeftHandSlot == interaction.SourceSlot ? parent.RightHandSlot : parent.LeftHandSlot;
                var occupantStackable = destinationSlot.Occupant as Stackable;
                if (occupantStackable != null && occupantStackable.PrefabHash == newStack.PrefabHash)
                {
                    occupantStackable.Merge(newStack);
                }
                else if (destinationSlot.Occupant == null)
                {
                    newStack.MoveToSlot(destinationSlot, newStack, false);
                }
            }
        }
    }
}