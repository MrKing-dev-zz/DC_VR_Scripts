using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighlanderScript_SettingsCanvas : MonoBehaviour
{

    public static HighlanderScript_SettingsCanvas highlanderSet;

    

    void Awake()
    {
        if (highlanderSet == null)
        {
            DontDestroyOnLoad(gameObject);
            highlanderSet = this;

        }
        else if (highlanderSet != this)
        {
            Destroy(gameObject);
        }
        
        
    }

    
}
