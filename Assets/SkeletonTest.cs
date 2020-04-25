using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonTest : MonoBehaviour
{
    private Animator anim;

    public float IK_rightWeight = 1;
    public Transform IK_rightHandTarget;
    
    public float IK_leftWeight = 1;
    public Transform IK_leftHandTarget;
    
    public float IK_rightLegWeight = 1;
    public Transform IK_rightLegTarget;
    
    public float IK_leftLegWeight = 1;
    public Transform IK_leftLegTarget;

    public Transform lookPoint;


    private void Update()
    {
        transform.localRotation = Quaternion.Euler(0,0,0);
    }

    private void OnAnimatorIK(int layerIndex)
    {   
        anim = GetComponent<Animator>();
        
        if (IK_rightHandTarget != null)
        {
            anim.SetIKPositionWeight(AvatarIKGoal.RightHand, IK_rightWeight);
            anim.SetIKRotationWeight(AvatarIKGoal.RightHand, IK_rightWeight);
            anim.SetIKPosition(AvatarIKGoal.RightHand, IK_rightHandTarget.position);
            anim.SetIKRotation(AvatarIKGoal.RightHand, IK_rightHandTarget.rotation);
        }
        if (IK_leftHandTarget != null)
        {
            anim.SetIKPositionWeight(AvatarIKGoal.LeftHand, IK_leftWeight);
            anim.SetIKRotationWeight(AvatarIKGoal.LeftHand, IK_leftWeight);
            anim.SetIKPosition(AvatarIKGoal.LeftHand, IK_leftHandTarget.position);
            anim.SetIKRotation(AvatarIKGoal.LeftHand, IK_leftHandTarget.rotation);
        }
        if (IK_rightLegTarget != null)
        {
            anim.SetIKPositionWeight(AvatarIKGoal.RightFoot, IK_rightLegWeight);
            anim.SetIKRotationWeight(AvatarIKGoal.RightFoot, IK_rightLegWeight);
            anim.SetIKPosition(AvatarIKGoal.RightFoot, IK_rightLegTarget.position);
            anim.SetIKRotation(AvatarIKGoal.RightFoot, IK_rightLegTarget.rotation);
        }
        if (IK_leftLegTarget != null)
        {
            anim.SetIKPositionWeight(AvatarIKGoal.LeftFoot, IK_leftLegWeight);
            anim.SetIKRotationWeight(AvatarIKGoal.LeftFoot, IK_leftLegWeight);
            anim.SetIKPosition(AvatarIKGoal.LeftFoot, IK_leftLegTarget.position);
            anim.SetIKRotation(AvatarIKGoal.LeftFoot, IK_leftLegTarget.rotation);
        }
        
        anim.SetLookAtPosition(lookPoint.transform.position);
        anim.SetLookAtWeight(0.35f);//0.5f - means it rotates head 50% mixed with real animations
    }
}
