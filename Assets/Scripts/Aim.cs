using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public GameObject gun;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            gun.transform.localPosition = new Vector3(0, -0.163f, 1.354f);
        }
        else
        {
            gun.transform.localPosition = new Vector3(0.5f, -0.25f, 1.5f);
        }
    }
}
