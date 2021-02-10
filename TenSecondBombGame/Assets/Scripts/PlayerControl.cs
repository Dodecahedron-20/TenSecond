using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float rotationSpeed = 8;  

    public Camera cam;  

    void Update()
    {
        RotateObject();
    }

    void RotateObject()
    {      
        Vector3 mousePos = Input.mousePosition;
        
        mousePos.z = cam.transform.position.y - transform.position.y;

        Vector3 mouseWorldPos = cam.ScreenToWorldPoint(mousePos);

        float angle = -Mathf.Atan2(transform.position.z - mouseWorldPos.z, transform.position.x - mouseWorldPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, angle, 0), rotationSpeed * Time.deltaTime);
    }
}
