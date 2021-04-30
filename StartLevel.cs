using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class StartLevel : MonoBehaviour
{

    public CinemachineFreeLook freelook;
    public GameObject PlayerOne;
    public GameObject SpawnLocation;
    public bool runSpawn = true;

    // Start is called before the first frame update
    void Start()
    {
        //Create the random level via the Level Generator script
        gameObject.GetComponent<LevelGenerator.Scripts.LevelGenerator>().RunLevel();
        
       
    }

    // Update is called once per frame
    void Update()
    {
        if (runSpawn == true)
        {
            
           //Bake the NavMesh via the NavigationBaker script
            gameObject.GetComponent<NavigationBaker>().BakeIt();
            gameObject.GetComponent<PlayerSpawn_Dungeon>().SetVariables();
            gameObject.GetComponent<PlayerSpawn_Dungeon>().SpawnPlayer();
            //GameObject.FindGameObjectWithTag("Player").GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().SetCam();


            //Flip the bool
            runSpawn = false;

        }
    }
}
