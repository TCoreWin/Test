using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using PathCreation;

public class AnimCurve : MonoBehaviour
{
    [SerializeField] private AnimationCurve animC;
    [SerializeField] private GameObject cube;

    [SerializeField] PathCreator path;

    private EndOfPathInstruction end = EndOfPathInstruction.Reverse;

    
    private float time;
    private bool inverse = false;

    private void Update()
    {   
        if (!inverse)
        {   
            time += Time.deltaTime;
            
            if (time >= 1)
            {
                time = 1;
                inverse = true;
            }            
        }
        else
        {    
            time -= Time.deltaTime;
            
            if (time <= 0)
            {  
                time = 0;
                inverse = false;
            }
        }
        
        //if(time > 1 || time < 0) Debug.LogError("TimeError");
        cube.transform.position = path.path.GetPointAtTime(animC.Evaluate(time), end);
        
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(animC.Evaluate(time));
        
            if (animC.Evaluate(time) > .4f && animC.Evaluate(time) < .6f)
            {
                Debug.Log("Green");
            }
            if (animC.Evaluate(time) >= 0f && animC.Evaluate(time) <= .4f || animC.Evaluate(time) >= .6f && animC.Evaluate(time) <= 1f )
            {
                Debug.Log("Red");
            }
        }
    }
}
