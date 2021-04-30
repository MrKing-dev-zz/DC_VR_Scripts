using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;

public class PlayerSpawn_Dragon : MonoBehaviour
{

    //public CinemachineFreeLook freelookfollow;
    public GameObject SpawnLocation;
    public GameObject PlayerOne;




    // Start is called before the first frame update


    

    void Start()
    {

        //Spawn the Player at the location of the player spawn point

        PlayerOne = GameObject.FindGameObjectWithTag("Player");
        PlayerOne.transform.position = SpawnLocation.transform.position;
        //RenderSettings.fogDensity = 0.04f;
        //PlayerOne.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().SetCam();



        //Set the camera settings to the new player instantiated just now.
        //freelookfollow.m_LookAt = GameObject.FindWithTag("Look").transform;
        //freelookfollow.m_Follow = GameObject.FindWithTag("Player").transform;
        //Set the camera's priority high enough to make it the primary camera.
        //freelookfollow.m_Priority = 11;

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
