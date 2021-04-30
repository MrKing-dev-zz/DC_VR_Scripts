using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;



public class BACK_MusicManager : MonoBehaviour
{
    public AudioMixer masterMixer;
    public AudioSource titleMusic;
    public AudioSource fightMusic;
    public AudioSource exploreMusic;
    


    void Awake()
    {
        titleMusic.Play();
    }

    IEnumerator playFight()
    {
        titleMusic.Pause();
        exploreMusic.Pause();
        fightMusic.Play();
        yield return new WaitForSeconds(20.0f);
        playExplore();
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MusicStart")

        {
            if (!fightMusic.isPlaying)
            {
                StartCoroutine(playFight());
            }
        }
        

     }

    void playExplore()
    {
                
            titleMusic.Pause();
            fightMusic.Pause();
            exploreMusic.Play();
                  
    }
}
