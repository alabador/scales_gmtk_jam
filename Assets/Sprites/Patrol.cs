using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    [SerializeField] private Rigidbody2D myRigidbody;
    [SerializeField] private SpriteRenderer myRenderer;
    public Animator anim;
    [SerializeField] private string movementAnim;

    public float speed;
    public float rayDistance;
    private bool movingRight = true;

    public Transform groundDetection;

    void Update()
    {
        // Starts moving right
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        anim.Play(movementAnim);

        // Creates a raycast to detect for collisions in direction
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, rayDistance);
        if (groundInfo.collider == false)
        {
            if (movingRight)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
    }

}
