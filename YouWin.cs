using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouWin : MonoBehaviour
{

    Animator HUDanim;
    public GameObject GameOverText;
    public GameObject DragonCanvas;

    

    
    void Death()
    {
        DragonCanvas.SetActive(false);
        GameOverText = GameObject.Find("GameOverText");
        GameOverText.GetComponent<Text>().text = "You Win!";
        GameControl.control.GameOver();

        //HUDanim = GameObject.Find("HUDCanvas").GetComponent<Animator>();
        
        //HUDanim.SetTrigger("GameOver");
        //StartCoroutine(AppQuit());
    }
    //IEnumerator AppQuit()
    //{
    //    yield return new WaitForSeconds(5);
    //    Application.Quit();


    //}
}
