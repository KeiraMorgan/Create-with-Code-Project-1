using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerFirstPerson : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3 (0,1.9f,0.5f);
    //public GameObject firstPersonCamera;
    // Start is called before the first frame update
    void Start()
    {
        //firstPersonCamera = GameObject.FindGameObjectWithTag("Player");
        //firstPersonCamera.SetActive(false);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        transform.rotation = player.transform.rotation;

    }
}
