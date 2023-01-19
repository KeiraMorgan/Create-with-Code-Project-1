using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCameraPlayer2 : MonoBehaviour
{
    private GameObject firstPersonCamera;
    private GameObject thirdPersonCamera;
    private bool switchCamera = false;
    // Start is called before the first frame update
    void Start()
    {
        firstPersonCamera = GameObject.FindGameObjectWithTag("Player2 First");
        thirdPersonCamera = GameObject.FindGameObjectWithTag("Player2 Third");

        firstPersonCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        switchCamera = Input.GetButtonDown("Fire2");
        if (switchCamera && firstPersonCamera.activeSelf)
        {
            thirdPersonCamera.SetActive(true);
            firstPersonCamera.SetActive(false);
        }
        else if (switchCamera && thirdPersonCamera.activeSelf)
        {
            firstPersonCamera.SetActive(true);
            thirdPersonCamera.SetActive(false);
        }
    }
}
