using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class DummyTrigger : NetworkBehaviour
{
    [SerializeField] private GameObject[] TargetDummies;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            foreach(GameObject Dummies in TargetDummies)
            {
                Dummies.GetComponent<TargetDummy>().ActivateDummy();
            }
        }
    }
}
