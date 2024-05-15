using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.Netcode;

public class ScoreController : NetworkBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI winText;
    public static int collisionCount = 0;

    void Update()
    {
        
        if (collisionCount == 9)
        {
            scoreText.text = "" + collisionCount;
            winText.text = "YOU WIN!";
        }
        else
        {
            scoreText.text = "" + collisionCount;
        }
    }

}
