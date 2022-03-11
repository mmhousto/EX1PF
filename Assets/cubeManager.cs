using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeManager : MonoBehaviour
{

    Rigidbody rb;
    public ParticleSystem ps;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("left"))
        {
            rb.AddForce(transform.right * -1);
        }
        if (Input.GetKey("right"))
        {
            rb.AddForce(transform.right * 1);
        }
    }
}
