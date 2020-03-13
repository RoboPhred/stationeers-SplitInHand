# SplitInHand for Stationeers

When splitting items, if the item in your offhand is the same as the item being split, the item will merge into your offhand stack.

# Releases

To download, visit the [Releases](https://github.com/RoboPhred/stationeers-SplitInHand/releases) page.

# Installation

Requires [BepInEx 5.0.1](https://github.com/BepInEx/BepInEx/releases) or later.

1. Install BepInEx in the Stationeers steam folder.
2. Launch the game, reach the main menu, then quit back out.
3. In the steam folder, there should now be a folder BepInEx/Plugins
4. Copy the `SplitInHand` folder from this mod into BepInEx/Plugins

# Multiplayer Support

If this mod is installed on a dedicated server, it will work for all clients.
If a client has this mod installed and joins the server, the mod will have no effect.

As of version 1.1, this mod also fixes a base game bug where a client attempting to split will see the item drop on the floor even though the server thinks the player has it held
in their hands. This allows splitting to work properly for clients other than the host.
