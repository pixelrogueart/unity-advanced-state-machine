using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpState : ExampleMainState
{
    public override void Enter()
    {
        example.mainText.text = "up state";
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
        if (Input.GetKeyDown(KeyCode.RightArrow)) 
            {
                return example.ChangeToState("Right"); 
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
