using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftState : ExampleMainState
{
    public override void Enter()
    {
        example.mainText.text = "left state";
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
        if (Input.GetKeyDown(KeyCode.RightArrow)) 
            {
                return example.ChangeToState("Right"); 
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
