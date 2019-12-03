using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogMovement : MonoBehaviour
{
    public float dogSpeed = 1.0f;

    Rigidbody2D rb2d;
    Animator animator;
    SpriteRenderer spriteRndr;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();             // Update rigidbody2d references.
        animator = GetComponent<Animator>();            // Update animator references.
        spriteRndr = GetComponent<SpriteRenderer>();    // Update spriterenderer references.
    }

    private void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") != 0)
            MoveHorizontal();

        else
            Idle();

    }
    void MoveHorizontal()
    {
        float moveH = Input.GetAxis("Horizontal");                          // Save the input movement direction into moveH.

        rb2d.velocity = new Vector2(moveH * dogSpeed, rb2d.velocity.y);     // Updates the rb2D velocity in x axis by multiply 
                                                                            // the input and the dogSpeed.
        if (moveH > 0)
        {
            spriteRndr.flipX = false;                                       // Unflips the sprite in X value.
        }
        else if (moveH < 0)
        {
            spriteRndr.flipX = true;                                        // Unflips the sprite in X value.
        }

        animator.SetBool("Moving", true);                                   // Sets the Moving bool to true (Used by animator to switch between states.

    }

    void Idle()
    {
        rb2d.velocity = new Vector2(0.0f, rb2d.velocity.y);

        animator.SetBool("Moving", false);                                 // Sets the Moving bool to false (Used by animator to switch between states.

    }
}
