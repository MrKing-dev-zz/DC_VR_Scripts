using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighlanderScript_PlayerOne : MonoBehaviour
{

    public static HighlanderScript_PlayerOne highlanderPlayer;

    

    void Awake()
    {
        if (highlanderPlayer == null)
        {
            DontDestroyOnLoad(gameObject);
            highlanderPlayer = this;

        }
        else if (highlanderPlayer != this)
        {
            Destroy(gameObject);
        }
        
        
    }

    
}
