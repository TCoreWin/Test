using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] Rigidbody rb;

    private float speed = 5f;

    private float scaleSpeed;
    
    private void Update()
    {
        
        
        if (Input.GetMouseButtonDown(0))
        {
            scaleSpeed = speed;
        }
        
        if (Input.GetMouseButton(0))
        {
            rb.AddForce(transform.forward * rb.mass * scaleSpeed);
            scaleSpeed = Mathf.Clamp(scaleSpeed + Time.deltaTime * 15f, speed, speed+5f);
            Debug.Log(scaleSpeed);
        }
    }
}
