using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TakeWeapons : MonoBehaviour
{

    

    void Start()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            GameControl.control.hasweapons = true;
        }


    }

    
}
