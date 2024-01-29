using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ExampleMainState : BaseState<Example>
{
    protected Example example;
    public override void Initialize(Example context)
    {
        base.Initialize(context);
        this.example = context;
        // Any further initialization specific to the pawn can be done here.
    }
    public override void Enter()
    {
        base.Enter();
        // Logic for when entering this state.
    }

    public override void Exit()
    {
        base.Exit();
        // Logic for when exiting this state.
    }

    public override BaseState<Example> HandleInput()
    {
        // Handle inputs specific to this state.
        return null;
    }

    public override BaseState<Example> UpdateState(float delta)
    {
        // Regular update logic specific to this state.
        return null;
    }

    public override BaseState<Example> PhysicsUpdateState(float delta)
    {
        // Physics-related update logic specific to this state.
        return null;
    }

}
