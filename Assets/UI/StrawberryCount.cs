using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class StrawberryCount : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI countText;
    public QuestGenerator QuestGenerator;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countText.text = Convert.ToString(QuestGenerator.wantedStrawberries);
    }
}
