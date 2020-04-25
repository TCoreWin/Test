using System.Collections;
using System.Collections.Generic;
using PathCreation;
using UnityEngine;

public class Racing : MonoBehaviour
{
    [SerializeField] private PathCreator pathC;

    public EndOfPathInstruction endOfPathInstruction;
    public float speed = 5;
    float distanceTravelled;
    
    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathC.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);
        transform.rotation = pathC.path.GetRotationAtDistance(distanceTravelled, endOfPathInstruction);
    }
}
