using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerTest : MonoBehaviour
{
    [SerializeField]private Transform leftHand;
    [SerializeField]private Transform rightHand;
    
    [SerializeField]private Transform leftFoot;
    [SerializeField]private Transform rightFoot;

    [SerializeField] private Transform leftPedal;
    [SerializeField] private Transform rightPedal;
    
    [SerializeField] private Transform leftSuspension;
    [SerializeField] private Transform rightSuspension;

    private void FixedUpdate()
    {
        leftHand.position = leftSuspension.position;
        rightHand.position = rightSuspension.position;
        rightFoot.position = rightPedal.position;
        leftFoot.position = leftPedal.position;
    }
}
