using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    public Rigidbody rb;
    public float SideForse;
    public float ForwardForce;
    public float UpwardForce;
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(0, 0, SideForse * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(0, 0, -SideForse * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(-ForwardForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(ForwardForce* Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.U))
        {
            rb.AddForce(0, UpwardForce * Time.deltaTime, 0);
        }
        }
}
