using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicController : MonoBehaviour
{
    [SerializeField] public PlatformController platformController;
    private List<GameObject> fruitsOnScale;
    private int totalFruits; 

    void Start()
    {
        fruitsOnScale = platformController.fruitsOnScale;
    }

    void Update()
    {
        totalFruits = fruitsOnScale.Count;
        Debug.Log($"{totalFruits}");
    }
}
