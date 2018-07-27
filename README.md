# MokaPot kata

Sample application simulating an automated coffee machine.

## Requirements:

1. Create a console app for the coffee machine maintenance functionalitites
1. From the console app the engineer needs to be able to kick off a cleaning cycle
1. Create a website for the users to interact with the machine. 
The website allows the user to choose the options to make the coffee (espresso, cappuccino, latte, americano)
1. Before any new coffee is made, the machine must run a cleaning cycle automatically
1. The software will interact with the physical machine through the interface *ICoffeeMachineService*. A mock implementation of the machine logic is provided: *CoffeeMachineService*.

## Operating directions for the machine:

1. To run a steam blast, water must be recharged first (```GetWater()``` method)
1. Maximum water is ```100 ml```
1. To make espresso coffee the machine needs to recharge ```50ml``` water and ```6mg``` coffee (```SetCoffee()``` method).
1. The maximum coffee allowed is ```10gr```
1. Neither water nor coffee can be missing
1. The steam blast duration in order to clean the machine has to be longer than ```5 seconds```
1. Maximum steam blast allowed is ```10 seconds```