using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GripAlternation : XRGrabInteractable
{
    public Transform leftGrip;
    public Transform rightGrip;
    
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (args.interactableObject.transform.CompareTag("Left Hand"))
        {
            gameObject.GetComponent<GripAlternation>().attachTransform = leftGrip;
        }
        else if (args.interactableObject.transform.CompareTag("Right Habd"))
        {
            gameObject.GetComponent<GripAlternation>().attachTransform = rightGrip;
        }
        base.OnSelectEntered(args);
    }
}
