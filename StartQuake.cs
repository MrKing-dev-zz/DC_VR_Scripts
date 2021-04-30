using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class StartQuake : MonoBehaviour
{
    bool runQuake = true;
    float soundCount = 0;
    public AudioSource quakeSound;
    public MusicManager_Dragon MusicManager;
    

    
    

    // Update is called once per frame
    void Update()
    {
       if(runQuake == true)
        {

            StartCoroutine(PlayQuake());


            runQuake = false;
        }
    }

    IEnumerator PlayQuake()
    {
        StartCoroutine(AudioController.FadeIn(quakeSound, 1f));
        yield return new WaitForSeconds(8);
        MusicManager.PlayTitle();
        StartCoroutine(AudioController.FadeOut(quakeSound, 4f));
        

    }

}
