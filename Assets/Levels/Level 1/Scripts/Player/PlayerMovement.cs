using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Animation anim;
    public GameObject player;
    public float moveSpeed = 5f;
    private bool facingRight = true;
    public Rigidbody2D rigid;
    public Vector2 jumpHeight;
    public bool isGrounded;
    public Transform groundCheck;
    public LayerMask whatIsGround;
    
    private void Update()
    { 
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.5f, whatIsGround);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (facingRight) Flip();
            player.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (facingRight == false) Flip();
            player.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (isGrounded) rigid.AddForce(jumpHeight, ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (isGrounded) rigid.AddForce(jumpHeight, ForceMode2D.Impulse);
        }
    }
    
    void Flip()
    {
        // Switch the way the player is labelled as facing
        facingRight = !facingRight;

        // Multiply the player's x local scale by -1
        Vector3 theScale = player.transform.localScale;
        theScale.x *= -1;
        player.transform.localScale = theScale;
    }
}
