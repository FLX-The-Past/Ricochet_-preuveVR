using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimationOnInput : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty pinchAniationGrip;

    public Animator handAnimator;
    void Start()
    {
        
    }

    
    void Update()
    {
      float triggerValue = pinchAnimationAction.action.ReadValue<float>();
      handAnimator.SetFloat("Trigger", triggerValue);
      float gripValue = pinchAniationGrip.action.ReadValue<float>();
      handAnimator.SetFloat("Grip", gripValue);
    }
}
