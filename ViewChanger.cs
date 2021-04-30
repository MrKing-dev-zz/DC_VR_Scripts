using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ViewChanger : MonoBehaviour
{
    public CinemachineVirtualCamera DiabloCam;
    public CinemachineFreeLook CloseCam;
    bool defaultView = true;

    
    
    // Start is called before the first frame update
    void Start()
    {
        CloseCam.gameObject.SetActive(false);
        DiabloCam.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
       //if (Input.GetButtonDown("View"))
       if (Input.GetKeyDown("v"))
        {
            if (defaultView == true)
            {
                CloseCam.gameObject.SetActive(true);
                DiabloCam.gameObject.SetActive(false);
                defaultView = false;
            }

            else
            {
                DiabloCam.gameObject.SetActive(true);
                CloseCam.gameObject.SetActive(false);
                defaultView = true;
            }
            
        }
        
    }
}
