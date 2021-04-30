using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;



public class MusicManager : MonoBehaviour
{
    public AudioMixer masterMixer;
    public AudioSource titleMusic;
    public AudioSource fightMusic;
    public AudioSource exploreMusic;
    


    void Awake()
    {
        //titleMusic.Play();
        StartCoroutine(AudioController.FadeIn(titleMusic, 2f));
    }

    IEnumerator playFight()
    {
        //titleMusic.Pause();
        //exploreMusic.Pause();
        //fightMusic.Play();
        StartCoroutine(AudioController.FadeOut(titleMusic, 1f));
        StartCoroutine(AudioController.FadeOut(exploreMusic, 1f));
        StartCoroutine(AudioController.FadeIn(fightMusic, 1f));
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

        //titleMusic.Pause();
        //fightMusic.Pause();
        //exploreMusic.Play();
        StartCoroutine(AudioController.FadeOut(fightMusic, 1f));
        StartCoroutine(AudioController.FadeOut(titleMusic, 1f));
        StartCoroutine(AudioController.FadeIn(exploreMusic, 1f));

    }
}
