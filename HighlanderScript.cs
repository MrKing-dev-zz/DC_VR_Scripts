using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighlanderScript : MonoBehaviour
{

    public static HighlanderScript highlander;

    

    void Awake()
    {
        if (highlander == null)
        {
            DontDestroyOnLoad(gameObject);
            highlander = this;

        }
        else if (highlander != this)
        {
            Destroy(gameObject);
        }
        
        
    }

    
}
