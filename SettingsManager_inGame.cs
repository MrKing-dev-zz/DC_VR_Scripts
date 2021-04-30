using UnityEngine;
using System.Collections;

public class SettingsManager_inGame : MonoBehaviour
{

    public GameObject Settings;
    public GameObject Camera;
    bool Paused = false;
    public FixedButton Sbutton;
    public Animator anim;



    void Start()
    {
        
        Settings.SetActive(false);


    }

    public void SettingsCanvas()
    {
        
            if (Time.timeScale == 0.0f)  //If Paused, unpause
            {
                Time.timeScale = 1.0f;
                //anim.SetTrigger("SettingsDown");
                Settings.SetActive(false);
                AudioListener.pause = false;
                Paused = false;
            }
            else if (Time.timeScale == 1.0f)  //If running, Pause
            {
                Time.timeScale = 0.0f;
                Settings.SetActive(true);
                //anim.SetTrigger("SettingsUp");
                AudioListener.pause = true;
                Paused = true;
            }
        }
    
    
}