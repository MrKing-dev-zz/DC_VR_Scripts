using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighlanderScript_HUDCanvas : MonoBehaviour
{

    public static HighlanderScript_HUDCanvas highlanderHUD;

    

    void Awake()
    {
        if (highlanderHUD == null)
        {
            DontDestroyOnLoad(gameObject);
            highlanderHUD = this;

        }
        else if (highlanderHUD != this)
        {
            Destroy(gameObject);
        }
        
        
    }

    
}
