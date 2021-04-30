using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnterDragonLair : MonoBehaviour
{

    public GameObject descObj;
    public Text description;
    public Animator HUDanim;
    public FixedButton Abutton;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerStay(Collider other)
    {
        HUDanim = GameObject.Find("HUDCanvas").GetComponent<Animator>();
        description = GameObject.Find("Description").GetComponent<Text>();
        Abutton = GameObject.Find("AttackButton").GetComponent<FixedButton>();


        if (other.tag == "Player")
        {
            if (Abutton.Pressed)
            {

                if (GameControl.control.bossbattle == true)
                {
                    descObj = GameObject.Find("HUDCanvas").GetComponent<HUDVariables>().descObj;
                    descObj.SetActive(false);
                    HUDanim.SetTrigger("Fade");
                    StartCoroutine(Wait());
                }
                else
                {
                    description.text = "You are not prepared to meet this foe. Turn back, and gain more experience.";
                }
                

            }

        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Dragon_Level");
    }
}
