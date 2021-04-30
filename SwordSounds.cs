using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSounds : MonoBehaviour
{
    public AudioSource sword1;
    public AudioSource sword2;

    // Start is called before the first frame update
    void playSword1()
    {
        sword1.Play();
    }

    void playSword2()
    {
        sword2.Play();
    }
}
