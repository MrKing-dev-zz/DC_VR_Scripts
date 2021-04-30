using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;

public class PlayerSpawn : MonoBehaviour
{

    public CinemachineFreeLook freelookfollow;
    public CinemachineVirtualCamera diablocam;
    public GameObject SpawnLocation;
    public GameObject PlayerOne;




    // Start is called before the first frame update


    private void Awake()
    {
        //Set the SpawnLocation to the gameobject in the scene created for the purpose - this must be done at runtime via script as the object does not exist until then.
        SpawnLocation = GameObject.Find("Player_Spawnpoint");
        PlayerOne = GameObject.FindGameObjectWithTag("Player");
        freelookfollow = GameObject.Find("CM_FreeLookFollow").GetComponent<CinemachineFreeLook>();
        diablocam = GameObject.Find("CM_DiabloCam").GetComponent<CinemachineVirtualCamera>();

    }

    void Start()
    {

       // PlayerOne.transform.position = SpawnLocation.transform.position;




        //Set the camera settings to the new player instantiated just now.
        freelookfollow.m_LookAt = GameObject.FindWithTag("Look").transform;
        freelookfollow.m_Follow = GameObject.FindWithTag("Player").transform;
        //Set the camera's priority high enough to make it the primary camera.
        freelookfollow.m_Priority = 11;

        //if there is an overhead cam in the scene, set its parameters.
        if (diablocam != null)
        {
            diablocam.m_Follow = GameObject.FindWithTag("Player").transform;
            diablocam.m_Priority = 11;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
