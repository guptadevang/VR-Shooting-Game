using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FixedXRGrabInteractable : XRGrabInteractable
{
    [SerializeField] private Transform LeftHandAttachTransform;
    [SerializeField] private Transform RightHandAttachTransform;
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if(args.interactorObject.transform.CompareTag("LeftHand"))
        {
            attachTransform = LeftHandAttachTransform;
        }
        if(args.interactorObject.transform.CompareTag("RightHand"))
        {
            attachTransform = RightHandAttachTransform;
        }
        base.OnSelectEntered(args);
    }
}
