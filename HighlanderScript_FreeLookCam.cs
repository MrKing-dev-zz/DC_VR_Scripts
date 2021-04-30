using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighlanderScript_FreeLookCam : MonoBehaviour
{

    public static HighlanderScript_FreeLookCam highlanderCam;

    

    void Awake()
    {
        if (highlanderCam == null)
        {
            DontDestroyOnLoad(gameObject);
            highlanderCam = this;

        }
        else if (highlanderCam != this)
        {
            Destroy(gameObject);
        }
        
        
    }

    
}
