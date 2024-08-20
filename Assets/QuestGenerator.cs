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

    public int timeAllowed;

    public int totalFruits;
    private int totalStrawberries = 1;
    private int totalLemons = 0;
    private int totalPears = 0;
    private int totalOranges = 0;

    public int wantedStrawberries;
    public int wantedLemons;
    public int wantedPears;
    public int wantedOranges;

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
            if (currentFruits[i].GetComponent<ObjectProperties>().fruitType == "Strawberry")
            {
                totalStrawberries += 1;
            }
            if (currentFruits[i].GetComponent<ObjectProperties>().fruitType == "Orange")
            {
                totalOranges += 1;
            }
            if (currentFruits[i].GetComponent<ObjectProperties>().fruitType == "Pear")
            {
                totalPears += 1;
            }
            if (currentFruits[i].GetComponent<ObjectProperties>().fruitType == "Lemon")
            {
                totalLemons += 1;
            }
        }

        timeAllowed = Random.Range(10, 40);

        // Now currentFruits should have items.
        wantedStrawberries = Random.Range(1, totalStrawberries);
        wantedOranges = Random.Range(1, totalOranges);
        wantedPears = Random.Range(1, totalPears);
        wantedLemons = Random.Range(1, totalLemons);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
