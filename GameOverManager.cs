using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameOverManager : MonoBehaviour
{
    public float restartDelay = 5f;         // Time to wait before restarting the level
    public AudioSource gameOverSound;
    public AudioMixer mixer;
    public GameObject Fader;



    Animator anim;                          // Reference to the animator component.
    float restartTimer;                     // Timer to count up to restarting the level
    public bool gameOver = false;
    


    void Awake()
    {
        // Set up the reference.
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (GameControl.control.playerhealth <= 0)
        {
            GameOver();

        }
    }

    public void GameOver()
    {
        // If the player has run out of health...

        // ... tell the animator the game is over.
        anim.SetTrigger("GameOver");
        mixer.SetFloat("AllVolume", -80);
        Fader.SetActive(false);
        if (gameOver == false)
        {
            gameOverSound.Play();
            gameOver = true;
        }

    }


}