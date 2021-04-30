using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DebugButtons : MonoBehaviour
{
    private void Start()
    {
        this.gameObject.SetActive(false);
    }

    public void SetScore()
    {
        GameControl.control.playerscore = 1000;

    }

    public void SetHealth()
    {
        GameControl.control.playerhealth = 10000;
    }

    public void KillPlayer()
    {
        GameControl.control.playerhealth = 0;
    }

    public void LoadStart()
    {
        SceneManager.LoadScene("First_Level");
    }

    public void LoadDungeon()
    {
        SceneManager.LoadScene("Dungeon_Level");
    }

    public void LoadDragon()
    {
        SceneManager.LoadScene("Dragon_Level");
    }

    public void KillDragon()
    {
        GameObject.Find("Dragon").GetComponent<BS_Main_Health>()._health = 0;
    }
}
