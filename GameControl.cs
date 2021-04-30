using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameControl : MonoBehaviour
{

    public static GameControl control;

    public int playerhealth;
    public int playerscore;
    public int scoreThreshold;
    public bool hasweapons = false;
    public bool hasdragonweapon = false;
    public bool bossbattle = false;
    public GameObject player;
    public AudioSource gameOverSound;
    public AudioMixer mixer;
    //public GameObject Fader;
    public Animator HUDanim;
    public bool gameOver = false;

    void Awake()
    {
        
        control = this;

        Scene scenename = SceneManager.GetActiveScene();

        if (scenename.name == "First_Level")
        {
            playerhealth = 1000;
            playerscore = 0;

        }
    }

    public void Update()
    {
        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        
        if (playerscore >= scoreThreshold)
        {
            bossbattle = true;
        }

        if (playerhealth <= 0)  //When the player runs out of health, end the game
        {
            GameOver();

        }
    }

    public void GameOver()
    {

        // ... tell the animator the game is over.
        HUDanim.SetTrigger("GameOver");
        mixer.SetFloat("AllVolume", -80);
        //Fader.SetActive(false);
        if (gameOver == false)
        {
            gameOverSound.Play();
            gameOver = true;
        }

    }

    public void Death()
    {
        hasweapons = true;
    }
}
