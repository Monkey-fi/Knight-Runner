using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed =1.5f;
    public Rigidbody2D rb;
    public Animator animator;
    public bool isGround = true;
    public float jumpHeight = 5f;

    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);

        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            Jump();
            isGround = false;
            animator.SetBool("Running Jump", true);
        }
    }

    void Jump()
    {
        Vector2 velocity = rb.velocity;
        velocity.y = jumpHeight;
        rb.velocity = velocity;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = true;
            animator.SetBool("Running Jump", false);
        }
    }
}