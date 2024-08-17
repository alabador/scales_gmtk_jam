using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D myRigidbody;
    [SerializeField] private float _speedModifier;
    [SerializeField] private float moveStrength;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            myRigidbody.position += Vector2.left * _speedModifier * moveStrength * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.D))
        {
            myRigidbody.position += Vector2.right * _speedModifier * moveStrength * Time.deltaTime;

        }
    }
}
