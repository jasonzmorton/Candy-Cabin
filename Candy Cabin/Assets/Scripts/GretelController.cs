using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GretelController : MonoBehaviour
{
    public Transform followObject;

    public Transform gretel;

    public GameObject follow;

    public GameObject gretelSprite;

    Animator animator;
    Rigidbody2D rigidbody2d;

    public Rigidbody followRigidbody;

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

        movex = rigidbody2d.velocity.y;
        movey = rigidbody2d.velocity.x;

        animator.SetFloat("MoveX", movex);
        animator.SetFloat("MoveY", movey);
    }
}
