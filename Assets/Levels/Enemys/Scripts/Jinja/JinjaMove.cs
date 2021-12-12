using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JinjaMove : MonoBehaviour
{

    private bool isRight;
    public Transform groundCheck;
    public LayerMask whatIsGround;

    private bool isGrounded = true; // Setting to true may cause jank
    public float speed = 10.0f;
    private bool isFirst = true;
    public float deathX;

    public float deathY;
    void Start()
    {
        // Set default direction
        isRight = true; // Change this to change the default direction
    }
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.5f, whatIsGround);
        
        // Move sprite left or right
        if (!isGrounded)
        {
            isRight = !isRight;
            Flip(); // Flip the sprite
        }
        if (isRight) transform.Translate (Vector2.right * speed * Time.deltaTime);
        else transform.Translate(Vector2.left * speed * Time.deltaTime);
        
    }
    
    void Flip()
    {
        if (!isFirst)
        {
            // Multiply the player's x local scale by -1
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
        }
        else isFirst = false;

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.tag == "Player")
        {
            col.transform.position = new Vector3(deathX, deathY);
        } 
    }
}
