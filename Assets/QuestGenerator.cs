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

        timeAllowed = Random.Range(20, 50);

        // Now currentFruits should have items.
        wantedStrawberries = Random.Range(0, totalStrawberries);
        wantedOranges = Random.Range(0, totalOranges);
        wantedPears = Random.Range(0, totalPears);
        wantedLemons = Random.Range(0, totalLemons);

        InvokeRepeating("Spawn", 3, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Spawn()
    {
        
        Vector3 randomPos = new Vector3(Random.Range(-6, 4), 3.5f, 0);

        Instantiate(fruits[Random.Range(0,4)], randomPos, Quaternion.identity);
    }

}
