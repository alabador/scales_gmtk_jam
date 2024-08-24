using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    private Vector2 originalPos;
    public List<GameObject> fruitsOnScale = new List<GameObject>();

    private void Start()
    {
        originalPos = transform.localPosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /// Adds to count of fruits currently on scale.
        
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "NPC")
        {
            if (!fruitsOnScale.Contains(collision.gameObject))
            {
                fruitsOnScale.Add(collision.gameObject);
            }
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        /// Gradually lowers the scale when fruit is on it. 
        
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "NPC")
        {
            if (transform.localPosition.y > -0.7f)
            {
                transform.Translate(0, -0.3f * Time.deltaTime, 0);
            }

        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "NPC")
        {
            
        }

    }

    //private void Update()
    //{
        
    //}
}
