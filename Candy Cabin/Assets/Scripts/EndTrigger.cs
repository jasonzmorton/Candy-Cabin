using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        Invoke("restartGame", 4);
    }

    public void restartGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
