using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimation : MonoBehaviour
{
    [SerializeField] private InputActionReference gripActionReference;
    [SerializeField] private InputActionReference triggerActionReference;

    Animator animator;
    string gripName = "Grip";
    string triggerName = "Pinch";

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animator == null) 
        {
            return;
        }
        float gripValue = gripActionReference.action.ReadValue<float>();
        float triggerValue = triggerActionReference.action.ReadValue<float>();

        animator.SetFloat(gripName, gripValue);
        animator.SetFloat(triggerName, triggerValue);


    }
}
