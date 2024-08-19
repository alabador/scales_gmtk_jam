using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    private Vector2 originalPos;
    bool isColliding = false;

    private void Start()
    {
        originalPos = transform.localPosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "NPC")
        {
                isColliding = true;

        }
        else
        {
            isColliding = false;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "NPC")
        {
            if (transform.localPosition.y > -0.7f)
            {
                transform.Translate(0, -0.1f * Time.deltaTime, 0);
                isColliding = true;
            }
            else
            {
                isColliding = false;
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "NPC")
        {
            //if (transform.localPosition.y < originalPos.y)
            //{
            //    transform.Translate(0, 0.01f, 0);
            //    isColliding = true;
            //}
        }

    }

    private void Update()
    {
        if (!isColliding)
        {
            if (transform.localPosition.y < originalPos.y)
            {
                transform.Translate(0, 0.1f * Time.deltaTime, 0);
            }

        }
    }
}
