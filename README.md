# SimpleStateMachine
A dead simple finite state machine written in CSharp for Unity3D with proper serialization.

There are two primary types of machines,  the single state machine and the multi state machine. This the basic interaction model is to create a state and create delegate functions that you subscribe to good. State enter and exits. This can be foregone to just have the functionality of detecting whether a state is active or not. 

The single state machine only allows one state to be active at a time. Changing the active state causes the previously active state to fire it's on state exit delegate. 

The multi state machine allows any number of states to be active active, but each state can only be added once. Adding the states fires the on state enter delegates,  and manually removing the state calls the on state exit version. 

There is also a Lite version of each state machine,  which utilizes string values. In this version, the state machine has events for entering and exiting a state. Which can be subscribed to. It will pass along the string state names that are being modified.  It is a good idea to make these strings consts for the class that owns the state machine. You can then switch on the state string that Is passed as a parameter. 
