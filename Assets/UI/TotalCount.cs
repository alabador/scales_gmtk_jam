using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TotalCount : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI countText;
    public QuestGenerator QuestGenerator;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countText.text = Convert.ToString(QuestGenerator.totalFruits);
    }
}
