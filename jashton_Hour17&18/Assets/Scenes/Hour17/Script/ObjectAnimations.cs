using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAnimations : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        if (animator == null)
        {
            Debug.LogError("Animator component not found on this object!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (animator == null) return;

        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("ColorTrigger");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("ScaleTrigger");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("SpinTrigger");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("HoverTrigger");
        }
    }
}
