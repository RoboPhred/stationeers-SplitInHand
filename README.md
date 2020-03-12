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

Splitting stacks is calculated on the server.  Installing this mod and joining a server will have no effect.  If the server has this mod installed, then the mod _should_ work for all clients.

However, in practice, there seems to be a bug with stack splitting for clients connected to a server.  The split stack never enters the other hand of non-host clients.  The server will think the player has the items in each hand, but the player will see the item drop to the ground.  This happens regardless of the mod being installed.

Because of this bug, the mod is effectively useless on servers at the moment.  If this bug is fixed, the mod should function as expected.
