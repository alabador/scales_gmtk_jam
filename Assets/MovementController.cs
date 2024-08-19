using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D myRigidbody;
    [SerializeField] private SpriteRenderer myRenderer;
    [SerializeField] private Animator anim;
    [SerializeField] private float _speedModifier;
    [SerializeField] private float moveStrength;

    // _current direction can be -1 or 1, indicates sprite x-axis direction
    private int _currentDirection = 1;

    // Jump
    [SerializeField] float _jumpStrength = 1f;

    // Dashing
    private bool _canDash = true;
    private bool _isDashing;
    [SerializeField] private float _dashingPower;
    private float _dashingTime = 0.3f;
    private float _dashingCooldown = 1f;
    private float _dragPower = 6f;

    public int CurrentDirection
    {
        get => _currentDirection;
        set => _currentDirection = value;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Idle Animation on release key
        if (Input.anyKey == false)
        {
            anim.Play("strawberry_idle");
        }

        if (Input.GetKey(KeyCode.W))
        {
            myRigidbody.position += Vector2.up * _jumpStrength * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.A))
        {
            CurrentDirection = -1;
            myRenderer.flipX = true;
            myRigidbody.position += Vector2.left * _speedModifier * moveStrength * Time.deltaTime;
            anim.Play("strawberry_walk");

        }
        if (Input.GetKey(KeyCode.D))
        {
            CurrentDirection = 1;
            myRenderer.flipX = false;
            myRigidbody.position += Vector2.right * _speedModifier * moveStrength * Time.deltaTime;
            anim.Play("strawberry_walk");

        }

        // Dashing
        if (_isDashing)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.LeftAlt) && _canDash)
        {
            if (CurrentDirection == 1)
            {
                StartCoroutine(Dash(CurrentDirection));

            }
            else
            {
                StartCoroutine(Dash(CurrentDirection));
            }
        }
    }

    private IEnumerator Dash(int direction)
    {
        //float originalGravity = 1f;

        _canDash = false;
        _isDashing = true;

        //myRigidbody.gravityScale = 0f;

        myRigidbody.velocity = new Vector2(transform.localScale.x * _dashingPower, 0f) * direction;
        myRigidbody.drag = _dragPower;

        //anim.Play("witch_run");
        //tr.emitting = true;

        yield return new WaitForSeconds(_dashingTime);

        //tr.emitting = false;
        // myRigidbody.gravityScale = originalGravity;
        myRigidbody.velocity = Vector2.zero;
        myRigidbody.drag = 0f;


        _isDashing = false;
        //anim.Play("witch_idle");


        yield return new WaitForSeconds(_dashingCooldown);
        _canDash = true;

    }
}
