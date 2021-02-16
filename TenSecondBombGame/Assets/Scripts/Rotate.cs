using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed;
    bool dragging = false;
    float tolerance = 0.01f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            dragging = false;
        }
    }

    void FixedUpdate()
    {
        if(dragging)
        {
            float x = Input.GetAxis("Mouse X");
            float y = Input.GetAxis("Mouse Y");

            Vector2 dragDirection = new Vector2(x, y);

            if(dragDirection.magnitude > tolerance)
            {
                x*= speed * Time.fixedDeltaTime;
                y *= speed * Time.fixedDeltaTime;

                rb.AddTorque(Vector3.down * x);
                rb.AddTorque(Vector3.right * y);
            }

            
        }
    }

    void OnMouseDrag()
    {
        dragging = true;
    }
}
