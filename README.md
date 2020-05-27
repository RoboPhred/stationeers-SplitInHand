# SplitInHand for Stationeers

When splitting items, if the item in your offhand is the same as the item being split, the item will merge into your offhand stack.

As of version 1.1, this mod also fixes a base game bug where a client attempting to split will see the item drop on the floor even though the server thinks the player has it held in their hands.

# Releases

To download, visit the [Releases](https://github.com/RoboPhred/stationeers-SplitInHand/releases) page.

# Installation

Requires [BepInEx 5.0.1](https://github.com/BepInEx/BepInEx/releases) or later.

1. Install BepInEx in the Stationeers steam folder.
2. Launch the game, reach the main menu, then quit back out.
3. In the steam folder, there should now be a folder BepInEx/Plugins
4. Copy the `SplitInHand` folder from this mod into BepInEx/Plugins

# Multiplayer Support

For this mod to work correctly, both client and server must have the mod.

If the client has the mod and the server does not, the client may experience issues with items displaying odd physics when being split.  To fix this, pick up the items, drop them, then pick them up again.

If the server has the mod and the client does not, the client will see the items fall in front of them but the server will think the items are in the player's hand.  If one client without the mod splits, the other client will see the items on the ground, and may 'steal' the item out of the other client's hands by picking it up.

