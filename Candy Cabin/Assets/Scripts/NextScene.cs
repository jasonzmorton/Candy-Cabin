using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextScene : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        Invoke("nextScene", 11);
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("Game");
        }
    }

    public void nextScene()
    {
        SceneManager.LoadScene("Game");
    }
    
}
