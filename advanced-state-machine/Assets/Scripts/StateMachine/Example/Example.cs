    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;

    public class Example : MonoBehaviour
    {

        [SerializeField, HideInInspector]public GameObject stateManager;
        [SerializeField, HideInInspector]public Animator animator;
        public Text mainText;
        public bool debug = true;

        private void Awake()
        {
            animator = GetComponent<Animator>();
            stateManager = transform.Find("StateManager").gameObject;
        }

        private void Start()
        {
            stateManager.GetComponent<ExampleStateManager>().Initialize(this);
        }

        private void Update()
        {
            stateManager.GetComponent<ExampleStateManager>().HandleUpdate(Time.deltaTime);
        }

        private void FixedUpdate()
        {
            stateManager.GetComponent<ExampleStateManager>().HandlePhysicsUpdate(Time.fixedDeltaTime);
        }

        private void OnGUI()
        {
            stateManager.GetComponent<ExampleStateManager>().HandleInput();
        }

        public BaseState<Example> ChangeToState(string stateName)
        {

            BaseState<Example> newState = stateManager.transform.Find(stateName)?.GetComponent<BaseState<Example>>();
            if (newState != null)
            {
                if (stateManager != null)
                {
                    stateManager.GetComponent<ExampleStateManager>().ChangeState(newState);
                    if (debug){
                        Debug.Log("Changed state: " + stateName);
                    }
                    return newState;
                }
            }
            return null;

        }
    }
