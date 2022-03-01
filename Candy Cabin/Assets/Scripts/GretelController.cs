using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GretelController : MonoBehaviour
{
    private Transform followObject;

    public Transform gretel;

    public GameObject follow;

    public GameObject gretelSprite;

    Animator animator;
    Rigidbody2D rigidbody2d;

    private Rigidbody followRigidbody;

    float x;
    float y;
    float z;

    float movex;
    float movey;


    void Start()
    {

        animator = GetComponent<Animator>();
        rigidbody2d = GetComponent<Rigidbody2D>();
        followRigidbody = follow.GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        x = follow.transform.position.x;
        z = follow.transform.position.z;

        gretelSprite.transform.position = new Vector3(x,2.47f,z);


        if (follow.transform.position.x != 21.4f)
        {
            animator.SetFloat("MoveX", 0.5f);
            animator.SetFloat("MoveY", 0.0f);
        }

        else
        {
            animator.SetFloat("MoveX", 0.0f);
            animator.SetFloat("MoveY", 0.0f);
        }
    }
}
