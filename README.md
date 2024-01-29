# Unity State Management System

## Overview
This Unity State Management System is a flexible framework for managing game states in Unity projects. It provides a generic state manager (`StateManager<TContext>`), an abstract base state (`BaseState<TContext>`), and an example implementation (`Example` and `ExampleStateManager`). This system is ideal for games requiring complex state management like character controllers, AI behaviors, game flow control, and more.

## Classes

### StateManager<TContext>
A generic MonoBehaviour that manages states. It uses a generic type `TContext` to provide a context to each state. 

- `Initialize(TContext context)`: Initializes all `BaseState<TContext>` children attached to this GameObject's children.
- `HandleUpdate(float delta)`: Regularly called to update the current state.
- `HandlePhysicsUpdate(float delta)`: Called during the physics update to handle physics-related state changes.
- `HandleInput()`: Handles input specific to the current state.
- `ChangeState(BaseState<TContext> newState)`: Changes the current state to the specified new state.

### BaseState<TContext>
An abstract MonoBehaviour that represents a single state in the state machine. 

- `Initialize(TContext context)`: Initializes the state with the given context.
- `Enter()`: Logic for when entering this state.
- `Exit()`: Logic for when exiting this state.
- `HandleInput()`: Processes inputs specific to this state.
- `UpdateState(float delta)`: Regular update logic specific to this state.
- `PhysicsUpdateState(float delta)`: Physics-related update logic specific to this state.

### Example
An example MonoBehaviour implementation using the state management system. 

- Contains a context with a StateManager attached and a few example states.
- Calls initialization and update methods on `ExampleStateManager`.
- `ChangeToState(string stateName)`: Changes to a specified state based on the state name.

### ExampleStateManager
An example implementation of `StateManager<TContext>` for the `Example` context.

## Usage
1. Check SampleScene for better understanding.

## Requirements
- Unity 2019.4 or later.
- Understanding of Unity's MonoBehaviour lifecycle.


## Contact
For questions or support, please contact pixelrogueart@gmail.com.

---
Made with by pixelrogue.
