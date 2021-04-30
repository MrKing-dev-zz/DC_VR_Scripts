using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameDamage : MonoBehaviour
{
    public int Damage;
    public float Speed;

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            InvokeRepeating("DamagePlayer", 0.5f, Speed);
        }
    }

    void DamagePlayer()
    {
        GameControl.control.playerhealth -= Damage;
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            CancelInvoke();
        }
    }
}
