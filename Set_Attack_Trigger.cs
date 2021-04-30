using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set_Attack_Trigger : MonoBehaviour
{
    public string Attack1 = "Attack1";
    public string Attack2 = "Attack2";
    public Animator playeranim;
    public Animator HUDanim;
    public bool canPower = true;
    public float coolDown = 4f;
    public bool canFire = true;
    public float fireDown = 1f;
    public FixedButton Abutton;
    public FixedButton Cbutton;





    void Awake()
    {
        
        playeranim = gameObject.GetComponent<Animator>();
    }


    void Update()
    {
        if (Abutton.Pressed)
        {
            if(canFire == true)
            {
                playeranim.SetTrigger(Attack1);
                StartCoroutine(Fire());
            }
        }

        if (Cbutton.Pressed)
        {
            if (canPower == true)
            {
                
                playeranim.SetTrigger(Attack2);
                StartCoroutine(PowerShot());
          
            }

            
        }
    }

    IEnumerator Fire()
    {
        canFire = false;
        yield return new WaitForSeconds(fireDown);
        canFire = true;

    }

    IEnumerator PowerShot()
    {
        canPower = false;
        HUDanim.SetTrigger("CoolDownGo");
        yield return new WaitForSeconds(coolDown);
        canPower = true;

    }
}
