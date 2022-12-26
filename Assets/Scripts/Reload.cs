using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetTrigger("Reload");
            animator.ResetTrigger("EndReload");
        }
    }

    public void EndAnimation()
    {
        animator.ResetTrigger("Reload");
        animator.SetTrigger("EndReload");
    }
}
