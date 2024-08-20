using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGenerator : MonoBehaviour
{
    public GameObject pear;
    public GameObject orange;
    public GameObject lemon;
    public GameObject strawberry;

    [SerializeField] private GameObject[] fruits = new GameObject[4];
    public GameObject[] currentFruits; 

    public int totalFruits;

    void Start()
    {
        // Populate fruits array with gameobjects
        fruits[0] = pear;
        fruits[1] = orange;
        fruits[2] = lemon;
        fruits[3] = strawberry;

        // Generate random amount of fruits, then randomize selection
        totalFruits = Random.Range(0, 11);
        currentFruits = new GameObject[totalFruits];
        for (int i = 0; i < totalFruits; i++)
        {
            currentFruits[i] = fruits[Random.Range(0, fruits.Length)];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
