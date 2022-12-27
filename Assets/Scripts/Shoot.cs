using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //gun.transform.localPosition = new Vector3(0, -0.163f, 1.354f);
            animator.SetTrigger("IdleShoot");
            animator.SetTrigger("AimShoot");
            animator.ResetTrigger("EndIdleShoot");
            animator.ResetTrigger("EndAimShoot");
        }
        else
        {
            //gun.transform.localPosition = new Vector3(0.5f, -0.25f, 1.5f);
            animator.ResetTrigger("IdleShoot");
            animator.ResetTrigger("AimShoot");
            animator.SetTrigger("EndIdleShoot");
            animator.SetTrigger("EndAimShoot");
        }
    }
}
