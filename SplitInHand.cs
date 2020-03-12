
using System;
using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace SplitInHand
{
    [BepInPlugin("net.robophreddev.stationeers.SplitInHand", "Split Stacks in Hand", "1.0.0.0")]
    public class SplitInHandPlugin : BaseUnityPlugin
    {
        public static SplitInHandPlugin Instance;


        public void Log(string line)
        {
            Debug.Log("[SplitInHand]: " + line);
        }

        void Awake()
        {
            SplitInHandPlugin.Instance = this;
            Log("Hello World");

            try
            {
                // Harmony.DEBUG = true;
                var harmony = new Harmony("net.robophreddev.stationeers.SplitInHand");
                harmony.PatchAll();
                Log("Patch succeeded");
            }
            catch (Exception e)
            {
                Log("Patch Failed");
                Log(e.ToString());
            }
        }
    }
}