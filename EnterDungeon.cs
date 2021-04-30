using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterDungeon : MonoBehaviour
{

    public GameObject descObj;
    public Animator HUDanim;
    public FixedButton Jbutton;

    void Start()
    {
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if(Jbutton.Pressed)
            {
                descObj = GameObject.Find("HUDCanvas").GetComponent<HUDVariables>().descObj;
                descObj.SetActive(false);
                
                HUDanim.SetTrigger("Fade");
                StartCoroutine(Wait());
                

            }

        }


    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Stairs_Level");
    }
}
