/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;       // How fast the character moves
    public float jumpHeight;      // How high the character jumps

    // Keyboard controls
    public KeyCode Spacebar;
    public KeyCode L;
    public KeyCode R;

    // Ground detection variables
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    private bool grounded;        // Is the character standing on solid ground?
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Jump when the user presses Space, but only when grounded
        if (Input.GetKeyDown(Spacebar) && grounded)
        {
            Jump();
        }

        // Move left
        if (Input.GetKey(L))
        {
            GetComponent<Rigidbody2D>().velocity =
                new Vector2(
                    moveSpeed,
                    GetComponent<Rigidbody2D>().velocity.y
                );

            // Flip the sprite to face left
            if (GetComponent<SpriteRenderer>() != null)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
        }

        // Move right
        if (Input.GetKey(R))
        {
            GetComponent<Rigidbody2D>().velocity =
                new Vector2(
                    moveSpeed,
                    GetComponent<Rigidbody2D>().velocity.y
                );

            // Flip the sprite to face right
            if (GetComponent<SpriteRenderer>() != null)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
        }
        anim.SetFloat("Speed",Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
        anim.SetFloat("Height", GetComponent<Rigidbody2D>().velocity.y);
        anim.SetBool("Grounded", grounded);
    }

    // Jump function
    void Jump()
    {
        GetComponent<Rigidbody2D>().velocity =
            new Vector2(
                GetComponent<Rigidbody2D>().velocity.x,
                jumpHeight
            );
    }

    // Check whether the character is standing on the ground
    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(
            groundCheck.position,
            groundCheckRadius,
            whatIsGround
        );
    }
}*/
