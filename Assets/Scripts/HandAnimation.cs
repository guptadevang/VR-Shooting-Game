using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimation : MonoBehaviour
{
    [SerializeField] private InputActionReference gripReference;
    [SerializeField] private InputActionReference triggerReference;
    [SerializeField] private Animator HandAnimator;
    // Update is called once per frame
    void Update()
    {
        float gripValue = gripReference.action.ReadValue<float>();
        HandAnimator.SetFloat("Grip", gripValue);

        float triggerValue = triggerReference.action.ReadValue<float>();
        HandAnimator.SetFloat("Trigger", triggerValue);
    }
}
