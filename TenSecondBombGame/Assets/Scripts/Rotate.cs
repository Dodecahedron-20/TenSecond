using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed;
    bool dragging = false;
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
            float x = Input.GetAxis("Mouse X") * speed * Time.fixedDeltaTime;
            float y = Input.GetAxis("Mouse Y") * speed * Time.fixedDeltaTime;

            rb.AddTorque(Vector3.down * x);
            rb.AddTorque(Vector3.right * y);
        }
    }

    void OnMouseDrag()
    {
        dragging = true;
    }
    
    //void OnMouseDrag()
    //{
    //    float rotX = Input.GetAxis("Mouse X") * speed * Mathf.Deg2Rad;
    //    float rotY = Input.GetAxis("Mouse Y") * speed * Mathf.Deg2Rad;

    //    transform.Rotate(Vector3.up, -rotX);
    //    transform.Rotate(Vector3.right, -rotY);
    //}
}
