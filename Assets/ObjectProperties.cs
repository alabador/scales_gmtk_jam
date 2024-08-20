using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectProperties : MonoBehaviour
{
    [SerializeField] public string fruitType;
    [SerializeField] private PlatformController platformController;
    private List<GameObject> fruitsOnScale;


    // Start is called before the first frame update
    void Start()
    {
        platformController = GameObject.Find("Scale Platform").GetComponent<PlatformController>();
        
        fruitsOnScale = platformController.fruitsOnScale;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -2.5)
        {
            fruitsOnScale.Remove(gameObject);
            Destroy(gameObject);
        }
    }

}
