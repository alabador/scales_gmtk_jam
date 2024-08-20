using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LogicController : MonoBehaviour
{
    [SerializeField] public PlatformController platformController;
    [SerializeField] public TextMeshProUGUI countTextElement;
    private List<GameObject> fruitsOnScale;
    private int totalFruits; 
    

    void Start()
    {
        fruitsOnScale = platformController.fruitsOnScale;
    }

    void Update()
    {
        totalFruits = fruitsOnScale.Count;
        countTextElement.text = totalFruits.ToString();
    }
}
