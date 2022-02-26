using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemy_master : MonoBehaviour
{
    public GameObject Player;
    public float Distance;

    public bool isFree;
    public GameObject box;
    public GameManager gameManager;

    public NavMeshAgent _agent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector3.Distance(Player.transform.position, this.transform.position);
        
        if(box == null)
        {
            isFree = true;
        }
        if(box != null)
        {
            isFree = false;
        }


        if(isFree)
        {
            _agent.isStopped = false;

            _agent.SetDestination(Player.transform.position);
        }
        if(!isFree)
        {
            _agent.isStopped = true;
        }

        if(this.transform.position.x <= -52f)
        {
            gameManager.CompleteLevel();
            Invoke("restartGame", 4);
        }
    }


    public void restartGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
