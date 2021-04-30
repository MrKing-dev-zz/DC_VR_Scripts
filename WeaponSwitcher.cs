using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class WeaponSwitcher : MonoBehaviour
{


    public AnimationClip[] A1AnimationClip;
    public AnimationClip[] A2AnimationClip;
    public GameObject[] WeaponList;
    public float[] WeaponSpeed;
   
    protected Animator anim;
    protected AnimatorOverrideController animatorOverrideController;
    public Animator HUDanim;
    public Text Weapontext;
    public GameObject Weapontextobj;
    public GameObject LargeSword;
    public GameObject SmallSword;



    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Start()
    {
        
        animatorOverrideController = new AnimatorOverrideController(anim.runtimeAnimatorController);
        anim.runtimeAnimatorController = animatorOverrideController;
        Weapontextobj.SetActive(false);

        SetWeapon1();
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (GameControl.control.hasweapons == false)
    //    {
    //        if (Input.GetKeyDown(KeyCode.Alpha1))
    //        {
    //            Weapontext.text = "You have no other weapons.";
    //            HUDanim.SetTrigger("WeaponSwitch");
    //        }

    //        if (Input.GetKeyDown(KeyCode.Alpha2))
    //        {
    //            Weapontext.text = "You have no other weapons.";
    //            HUDanim.SetTrigger("WeaponSwitch");
    //        }

    //        if (Input.GetKeyDown(KeyCode.Alpha3))
    //        {
    //            Weapontext.text = "You have no other weapons.";
    //            HUDanim.SetTrigger("WeaponSwitch");
    //        }
    //        if (Input.GetKeyDown(KeyCode.Alpha4))
    //        {
    //            Weapontext.text = "You have no other weapons.";
    //            HUDanim.SetTrigger("WeaponSwitch");
    //        }
    //    }

    //    if (GameControl.control.hasweapons == true)
    //    {
    //        if (Input.GetKeyDown(KeyCode.Alpha1))
    //        {
    //            SetWeapon1();
    //        }

    //        if (Input.GetKeyDown(KeyCode.Alpha2))
    //        {
    //            SetWeapon2();
    //        }

    //        if (Input.GetKeyDown(KeyCode.Alpha3))
    //        {
    //            SetWeapon3();
    //        }
    //        if (Input.GetKeyDown(KeyCode.Alpha4))
    //        {
    //            if(GameControl.control.hasdragonweapon == false)
    //            {
    //                Weapontext.text = "You do not have this weapon.";
    //                HUDanim.SetTrigger("WeaponSwitch");
    //            }
    //            if(GameControl.control.hasdragonweapon == true)
    //            {
    //                SetWeapon4();
    //            }
                
    //        }
    //    }
        

    //}

   public void SetWeapon1()
    {
        WeaponList[0].gameObject.SetActive(true);
        //WeaponList[1].gameObject.SetActive(false);
        //WeaponList[2].gameObject.SetActive(false);
        //WeaponList[3].gameObject.SetActive(false);
        //WeaponList[4].gameObject.SetActive(false);

        
        Weapontext.text = WeaponList[0].name;
        HUDanim.SetTrigger("WeaponSwitch");
        anim.SetTrigger("Unsheath");
        LargeSword.gameObject.SetActive(false);
        SmallSword.gameObject.SetActive(true);
        animatorOverrideController["ATTACK1"] = A1AnimationClip[0];
        animatorOverrideController["ATTACK2"] = A2AnimationClip[0];

        anim.SetFloat("AttackSpeed", WeaponSpeed[0]);



    }

    public void SetWeapon2()
    {
        WeaponList[1].gameObject.SetActive(true);
        WeaponList[0].gameObject.SetActive(false);
        WeaponList[2].gameObject.SetActive(false);
        WeaponList[3].gameObject.SetActive(false);
        //WeaponList[4].gameObject.SetActive(false);

        Weapontext.text = WeaponList[1].name;
        HUDanim.SetTrigger("WeaponSwitch");
        anim.SetTrigger("Unsheath");
        LargeSword.gameObject.SetActive(true);
        SmallSword.gameObject.SetActive(false);
        animatorOverrideController["ATTACK1"] = A1AnimationClip[1];
        animatorOverrideController["ATTACK2"] = A2AnimationClip[1];
        anim.SetFloat("AttackSpeed", WeaponSpeed[1]);
    }

    public void SetWeapon3()
    {
        WeaponList[2].gameObject.SetActive(true);
        WeaponList[0].gameObject.SetActive(false);
        WeaponList[1].gameObject.SetActive(false);
        WeaponList[3].gameObject.SetActive(false);
        //WeaponList[4].gameObject.SetActive(false);

        Weapontext.text = WeaponList[2].name;
        HUDanim.SetTrigger("WeaponSwitch");
        anim.SetTrigger("Unsheath");
        LargeSword.gameObject.SetActive(true);
        SmallSword.gameObject.SetActive(true);
        animatorOverrideController["ATTACK1"] = A1AnimationClip[2];
        animatorOverrideController["ATTACK2"] = A2AnimationClip[2];
        anim.SetFloat("AttackSpeed", WeaponSpeed[2]);
    }

    public void SetWeapon4()
    {
        WeaponList[3].gameObject.SetActive(true);
        WeaponList[0].gameObject.SetActive(false);
        WeaponList[1].gameObject.SetActive(false);
        WeaponList[2].gameObject.SetActive(false);
        //WeaponList[4].gameObject.SetActive(false);

        Weapontext.text = WeaponList[3].name;
        HUDanim.SetTrigger("WeaponSwitch");
        anim.SetTrigger("Unsheath");
        LargeSword.gameObject.SetActive(true);
        SmallSword.gameObject.SetActive(true);
        animatorOverrideController["ATTACK1"] = A1AnimationClip[3];
        animatorOverrideController["ATTACK2"] = A2AnimationClip[3];
        anim.SetFloat("AttackSpeed", WeaponSpeed[3]);
    }
}
