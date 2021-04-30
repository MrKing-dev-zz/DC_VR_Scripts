using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App_Quit : MonoBehaviour
{
    // Start is called before the first frame update
   public void Quit()
    {
        Debug.Log("has quit game");

        Application.Quit();
    }

}
