using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class SkyManager : NetworkBehaviour
{
    public float skySpeed;
    
    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time*skySpeed);
    }
}
