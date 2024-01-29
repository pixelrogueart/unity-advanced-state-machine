using UnityEngine;

public class StateManager<TContext> : MonoBehaviour where TContext : class

{
    [SerializeField]
    private BaseState<TContext> startingState;

    private BaseState<TContext> currentState;

    private TContext context;

    public void Initialize(TContext context)
    {
        // Initialize all BaseState children attached to direct children of this GameObject.
        foreach (Transform child in transform)
        {
            BaseState<TContext> state = child.GetComponent<BaseState<TContext>>();
            if (state != null)
            {
                state.Initialize(context);
            }
        }

        // Set the starting state.
        ChangeState(startingState);
        
    }

    public void HandleUpdate(float delta)
    {
        if (currentState != null)
        {
            BaseState<TContext> newState = currentState.UpdateState(delta);
            if (newState != null)
            {
                ChangeState(newState);
            }
        }
    }

    public void HandlePhysicsUpdate(float delta)
    {
        if (currentState != null)
        {
            BaseState<TContext> newState = currentState.PhysicsUpdateState(delta);
            if (newState != null)
            {
                ChangeState(newState);
            }
        }
    }

    public void HandleInput()
    {
        if (currentState != null)
        {
            BaseState<TContext> newState = currentState.HandleInput();
            if (newState != null)
            {
                ChangeState(newState);
            }
        }
    }

    public void ChangeState(BaseState<TContext> newState)
    {
        if (currentState != null)
        {
            currentState.Exit();
        }

        currentState = newState;
        currentState.Enter();
        // Debug.Log("changed to state: " + newState.name);
    }
}
