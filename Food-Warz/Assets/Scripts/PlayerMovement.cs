using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float horizontalMove = 0f;
    public float runspeed = 500f;
    bool jump = false;
    public bool buff = false;
    public Animator animator;
    public Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        animator.SetFloat("VerticalSpeed", rigidbody.velocity.y);
        animator.SetBool("IsGrounded", controller.m_Grounded);
        horizontalMove = Input.GetAxisRaw("Horizontal") * runspeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

    }

    private void FixedUpdate()
    {
        if(buff == true)
        {
            controller.Move(horizontalMove * Time.fixedDeltaTime * 2, false, jump);
        }
        else
        {
            controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        }
        
        jump = false;
    }
}