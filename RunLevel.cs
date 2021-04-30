using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;

public class RunLevel : MonoBehaviour
{

    public GameObject PlayerOne;
    public GameObject HUDCanvas;
   // public GameObject FreeLook;
    public Animator HUDanim;
    public GameObject PrimCam;

    // Start is called before the first frame update
    void Start()
    {
        PlayerOne = GameObject.FindGameObjectWithTag("Player");
        HUDCanvas = GameObject.Find("HUDCanvas");
       // FreeLook = GameObject.Find("CM_FreeLookFollow");
        HUDanim = GameObject.Find("HUDCanvas").GetComponent<Animator>();
        PrimCam = GameObject.Find("PrimCamera");

        HUDCanvas.SetActive(false);
        PlayerOne.SetActive(false);
        //FreeLook.SetActive(false);
        PrimCam.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "CutScene")
        {
            HUDCanvas.SetActive(true);
            HUDanim.SetTrigger("Fade");

            StartCoroutine(Wait());
            




        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        PlayerOne.SetActive(true);
       // FreeLook.SetActive(true);
        PrimCam.SetActive(true);


        SceneManager.LoadScene("Dungeon_Level");
    }
}
