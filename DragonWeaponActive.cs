using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonWeaponActive : MonoBehaviour

    

{
    private void OnTriggerEnter(Collider other)
    {
        if( other.tag == "Player")
        {
            GameControl.control.hasdragonweapon = true;
            GameObject.FindGameObjectWithTag("Player").GetComponent<WeaponSwitcher>().SetWeapon4();
            this.gameObject.SetActive(false);
        }

    }
}
