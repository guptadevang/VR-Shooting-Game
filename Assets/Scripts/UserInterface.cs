using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UserInterface : MonoBehaviour
{
    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        ScoreController.collisionCount = 0;
    }
    public void Exit()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
