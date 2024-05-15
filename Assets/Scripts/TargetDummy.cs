using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.Netcode;

public class TargetDummy : NetworkBehaviour
{
    [SerializeField] private Animator DummyAnimator;

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Bullet") || other.gameObject.CompareTag("Weapon"))
        {
            DummyAnimator.SetTrigger("Death");

            //Calculating the score
            ScoreController.collisionCount += 1;

            //Disabling the box collider
            GetComponent<BoxCollider>().enabled = false;

        }
    }
    
    public void ActivateDummy()
    {
        DummyAnimator.SetTrigger("Activate");
    }
}
