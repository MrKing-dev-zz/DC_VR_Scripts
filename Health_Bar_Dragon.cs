using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Bar_Dragon : MonoBehaviour
{
    public Slider healthbar;
    public BS_Main_Health healthscript;
    //public float maxHealth;


   

    // Update is called once per frame
    void Update()
    {

        healthbar.value = healthscript._health;
    }
}
