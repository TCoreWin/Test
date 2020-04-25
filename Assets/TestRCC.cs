using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRCC : MonoBehaviour
{
    private RCC_CarControllerV3 car;

    private void Awake()
    {
        car = FindObjectOfType<RCC_CarControllerV3>();
        
        //car.sound
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            car.gasInput = 1f;
        }  
        
        if (Input.GetMouseButtonDown(1))
        {
            car.engineTorque = 1000;
        }   
        
        if (Input.GetMouseButtonUp(0))
        {
            car.gasInput = 0f;
        }   
    }
}
