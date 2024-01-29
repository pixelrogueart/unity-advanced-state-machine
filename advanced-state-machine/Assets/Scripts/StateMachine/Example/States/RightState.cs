using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightState : ExampleMainState
{
    public override void Enter()
    {
        example.mainText.text = "right state";
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override BaseState<Example> HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
            {
                return example.ChangeToState("Center"); 
            }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) 
            {
                return example.ChangeToState("Left"); 
            }
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
            {
                return example.ChangeToState("Up"); 
            }
        if (Input.GetKeyDown(KeyCode.DownArrow)) 
            {
                return example.ChangeToState("Down"); 
            }
        return null;
    }

    public override BaseState<Example> UpdateState(float delta)
    {
        return null;
    }


    public override BaseState<Example> PhysicsUpdateState(float delta)
    {
        return null;
    }

}
