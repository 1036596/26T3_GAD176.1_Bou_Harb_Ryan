# 26T3_GAD176.1_Bou_Harb_Ryan
A simple progression system for adventure games

The project contains scripts for:
- A **Stat Class** containing variables and functions relation to a stat.
- A **Resource Stat Class** (Inherited from Stat): A special stat that has a value that increases and decreases according to certain events. (Akin to HP and Mana in traditional RPGs)
- A **Level Bar Class** that manages XP and level ups.
- A **Player Progression Manager** Monobehavior that contains:
    - The *required stats* that will be used in the game.
    - The *Level Bar* that will interact with the stats.
    - The functions that enable interaction between the stats and the level bar.
    - (Demonstration purposes) Gaining 20 XP by pressing the Space Bar.
    - (Demonstration purposes) A sample attack that uses the Resource Stat.
- An **Event Manager** that handles all Events and Actions related to progression (with a sample Action for tracking used Resource Stats)
- A text monobehavior that updates the text based on the resource used Action.
