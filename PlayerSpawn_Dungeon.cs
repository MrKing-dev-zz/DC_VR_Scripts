using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;

public class PlayerSpawn_Dungeon : MonoBehaviour
{

    public GameObject SpawnLocation;
    public GameObject PlayerOne;




    // Start is called before the first frame update


    public void SetVariables()
    {
        //Set the SpawnLocation to the gameobject in the scene created for the purpose - this must be done at runtime via script as the object does not exist until then.
        SpawnLocation = GameObject.Find("Player_Spawnpoint");
        PlayerOne = GameObject.FindGameObjectWithTag("Player");
    }

    public void SpawnPlayer()
    {

        PlayerOne.transform.position = SpawnLocation.transform.position;

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
