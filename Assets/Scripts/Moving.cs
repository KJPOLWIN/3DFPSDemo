using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public GameObject camera;
    public float speed = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Input.GetAxis("Vertical") * camera.transform.forward * Time.deltaTime * speed;
        transform.position += Input.GetAxis("Horizontal") * camera.transform.right * Time.deltaTime * speed;

        
    }
}
