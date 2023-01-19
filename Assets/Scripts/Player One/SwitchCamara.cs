using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamara : MonoBehaviour
{
    private GameObject firstPersonCamera;
    private GameObject thirdPersonCamera;
    private bool switchCamera = false;
    // Start is called before the first frame update
    void Start()
    {
        firstPersonCamera = GameObject.FindGameObjectWithTag("Player");
        thirdPersonCamera = GameObject.FindGameObjectWithTag("MainCamera");

        firstPersonCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        switchCamera = Input.GetButtonDown("Fire1");
        if(switchCamera && firstPersonCamera.activeSelf)
        {
            thirdPersonCamera.SetActive(true);
            firstPersonCamera.SetActive(false);
        } 
        else if(switchCamera && thirdPersonCamera.activeSelf)
        {
            firstPersonCamera.SetActive(true);
            thirdPersonCamera.SetActive(false);
        }
    }
}
