using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class NetworkPlayer : NetworkBehaviour
{

    //private NetworkVariable<int> netscorecounter = ScoreController.collisionCount;

    public void OnValueChanged()
    {
        
    }
    public Transform root;
    public Transform head;
    public Transform leftHand;
    public Transform rightHand;
    public Transform leftHandRay;
    public Transform rightHandRay;

    public Renderer[] meshToDisable;

    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();
        if(IsOwner)
        {
            foreach(var item in meshToDisable)
            {
                item.enabled = false;
            }
        }
    }
    
    void Update()
    {
        if(IsOwner)
        {
            root.position = VRRigReferences.Singleton.root.position;
            root.rotation = VRRigReferences.Singleton.root.rotation;

            head.position = VRRigReferences.Singleton.head.position;
            head.rotation = VRRigReferences.Singleton.head.rotation;

            leftHand.position = VRRigReferences.Singleton.leftHand.position;
            leftHand.rotation = VRRigReferences.Singleton.leftHand.rotation;

            rightHand.position = VRRigReferences.Singleton.rightHand.position;
            rightHand.rotation = VRRigReferences.Singleton.rightHand.rotation;

            leftHandRay.position = VRRigReferences.Singleton.leftHandRay.position;
            leftHandRay.rotation = VRRigReferences.Singleton.leftHandRay.rotation;

            rightHandRay.position = VRRigReferences.Singleton.rightHandRay.position;
            rightHandRay.rotation = VRRigReferences.Singleton.rightHandRay.rotation;
        }
        
    }
}
