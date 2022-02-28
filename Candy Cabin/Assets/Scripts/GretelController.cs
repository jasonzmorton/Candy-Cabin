using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GretelController : MonoBehaviour
{
    public Transform followObject;

    Animator animator;
    Rigidbody2D rigidbody2d;
    
    float movex;
    float movey;

    float beginX;
    float beginY;

    float endX;
    float endY;

    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2d = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        transform.position = followObject.position;

        beginX = rigidbody2d.transform.position.z;
        beginY = rigidbody2d.transform.position.x;
    }

    void LateUpdate()
    {
        endX = rigidbody2d.transform.position.z;
        endY = rigidbody2d.transform.position.x;

        movex = endX - beginX;
        movey = endY - beginY;

        animator.SetFloat("MoveX", movex);
        animator.SetFloat("MoveY", movey);

        
    }
}
