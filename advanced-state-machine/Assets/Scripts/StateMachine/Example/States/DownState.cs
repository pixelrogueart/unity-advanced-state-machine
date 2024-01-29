using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownState : ExampleMainState
{
    public override void Enter()
    {
        example.mainText.text = "down state";
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
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
            {
                return example.ChangeToState("Up"); 
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
