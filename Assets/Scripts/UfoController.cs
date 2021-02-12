using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoController : MonoBehaviour
{
    public float ufoSpeed = 0;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(transform.up * ufoSpeed);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-transform.right * ufoSpeed);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(transform.right * ufoSpeed);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(-transform.up * ufoSpeed);
        }
    }
}
