using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugActivate : MonoBehaviour
{
    public GameObject debugCanvas;
    int debugcount = 0;
    bool debugactive = false;

    public void ActivateDebug()
    {
        if (!debugactive)
        {
            if (debugcount < 6)
            {
                debugcount++;
            }
            else
            {
                debugCanvas.SetActive(true);
                debugactive = true;
                debugcount = 0;
            }
        }

        else
        {
            debugCanvas.SetActive(false);
            debugactive = false;
            
        }
    }
}
