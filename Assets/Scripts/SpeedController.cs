using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Inputs;
using UnityEngine.InputSystem;
using TMPro;

public class SpeedController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI sliderText = null;
    [SerializeField] private ActionBasedContinuousMoveProvider moveSpeed;
    // [SerializeField] private float MoveSpeed;
    public Slider mySlider;
    void Start()
    {
        mySlider.onValueChanged.AddListener(delegate{ValueChangeCheck();});
    }

    public void MoveSpeedUpdator()
    {
        // moveSpeed = mySlider.text;
        // mySlider = moveSpeed.action.ReadValue<float>();
        // MoveSpeed.SetFloat<ActionBasedContinuousMoveProvider>().moveSpeed = mySlider.text;
        // SpawndBullet.GetComponent<Rigidbody>().velocity = SpawnPoint.forward * BulletSpeed;
    }
    public void ValueChangeCheck()
    {
        Debug.Log(mySlider.value);
        sliderText.text = mySlider.value.ToString("0");
    }
}
