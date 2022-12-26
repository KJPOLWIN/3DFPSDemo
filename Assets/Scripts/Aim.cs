using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            //gun.transform.localPosition = new Vector3(0, -0.163f, 1.354f);
            animator.SetTrigger("AimTrigger");
            animator.ResetTrigger("EndAimTrigger");
        }
        else
        {
            //gun.transform.localPosition = new Vector3(0.5f, -0.25f, 1.5f);
            animator.ResetTrigger("AimTrigger");
            animator.SetTrigger("EndAimTrigger");
        }
    }//0, -1.5, -1.5
}
