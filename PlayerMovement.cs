using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed =1.5f;
    public Rigidbody2D rb;
    public bool isGround = true;
    public float jumpHeight = 5f;

    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);

        if (Input.GetKey(KeyCode.Space) && isGround == true )
        {
            Jump();
            isGround = false;
        }
    }

    void Jump()
    {
        Vector2 velocity = rb.velocity;
        velocity.y = jumpHeight;
        rb.velocity = velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "platform")
        {
            isGround = true;
        }
    }
}