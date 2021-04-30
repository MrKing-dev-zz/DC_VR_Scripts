using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{

    Animator anim;
    public Button settings;
    public Button back;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        settings.onClick.AddListener(OpenSettingsMenu);
        back.onClick.AddListener(CloseSettingsMenu);
    }

    
    void OpenSettingsMenu()
    {
        anim.SetTrigger("SettingsPressed");
    }

    void CloseSettingsMenu()
    {
        anim.SetTrigger("BackPressed");
    }
}
