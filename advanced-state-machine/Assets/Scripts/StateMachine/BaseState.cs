using UnityEngine;

public abstract class BaseState<TContext> : MonoBehaviour where TContext : class
{
    protected TContext context;

    public void Awake()
    {
        // If any initialization that doesn't involve external references is needed, it can go here.
    }

    public void Start()
    {
        // Similar to GDScript's _ready. Initialization involving external references can be handled here.
    }

    public virtual void Initialize(TContext context)
    {
        this.context = context;
        // Further initialization with context
    }

    public virtual void Enter()
    {
        // Logic for when entering this state.
    }

    public virtual void Exit()
    {
        // Logic for when exiting this state.
    }

    public virtual BaseState<TContext> HandleInput()
    {
        // Handle inputs specific to this state.
        return null;
    }

    public virtual BaseState<TContext> UpdateState(float delta)
    {
        // Regular update logic specific to this state.
        return null;
    }

    public virtual BaseState<TContext> PhysicsUpdateState(float delta)
    {
        // Physics-related update logic specific to this state.
        return null;
    }
}
