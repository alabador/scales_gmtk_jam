using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D collisionBody;
    private float _defaultGravity = 1f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            collisionBody.gravityScale = 0;
        }

        if (collisionBody.gameObject.tag == "Player" || collisionBody.gameObject.tag == "NPC")
        {
            if (collision.gameObject.tag == "Platform")
            {
                collisionBody.gravityScale = 0;
            }
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            collisionBody.gravityScale = 0;
        }
        
        if (collisionBody.gameObject.tag == "Player" || collisionBody.gameObject.tag == "NPC")
        {
            if (collision.gameObject.tag == "Platform")
            {
                collisionBody.gravityScale = 0;
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            collisionBody.gravityScale = _defaultGravity;
        }

        if (collisionBody.gameObject.tag == "Player" || collisionBody.gameObject.tag == "NPC")
        {
            if (collision.gameObject.tag == "Platform")
            {
                collisionBody.gravityScale = _defaultGravity;
            }
        }
    }
}
