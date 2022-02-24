using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_master : MonoBehaviour
{
    public GameObject Player;
    public float Distance;

    public bool isFree;

    public NavMeshAgent _agent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector3.Distance(Player.transform.position, this.transform.position);
        
        if(Distance <= 10f)
        {
            isFree = true;
        }
        if(Distance > 10f)
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
    }
}
