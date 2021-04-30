using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Bar : MonoBehaviour
{
    public Slider healthbar;
    //public float maxHealth;


   

    // Update is called once per frame
    void Update()
    {
        healthbar.value = GameControl.control.playerhealth;
    }
}
