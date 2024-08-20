using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera startCamera;
    public Camera playerCamera;

    void Start()
    {
        startCamera.enabled = true;
        playerCamera.enabled = false;
        StartCoroutine(SwitchCameraAfterDelay());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SwitchCameraAfterDelay()
    {
        yield return new WaitForSeconds(5);
        startCamera.enabled = false;
        playerCamera.enabled = true;

    }
}
