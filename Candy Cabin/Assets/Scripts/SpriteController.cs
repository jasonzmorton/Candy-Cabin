using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{
    public Transform sprite;
    public Transform controller;

    Animator animator;
    Rigidbody2D rigidbody2d;

    float movex;
    float movey;


    void Start()
    {
        transform.position = controller.position;

        animator = GetComponent<Animator>();
        rigidbody2d = GetComponent<Rigidbody2D>();

        
    }

    void Update()
    {
        transform.position = controller.position;

        movex = Input.GetAxis("Horizontal");
        movey = Input.GetAxis("Vertical");

        animator.SetFloat("MoveX", movex);
        animator.SetFloat("MoveY", movey);
    }
}
