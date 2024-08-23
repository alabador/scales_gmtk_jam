using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;


public class LemonCount : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI countText;
    public QuestGenerator QuestGenerator;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        countText.text = Convert.ToString(QuestGenerator.wantedLemons);

    }
}
