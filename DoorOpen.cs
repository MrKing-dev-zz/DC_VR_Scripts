using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour

{ 
    public AudioSource creakNoise;
Animator anim;

    // Start is called before the first frame update
    void Start()
    {
    anim = gameObject.GetComponent<Animator>();
}

// Update is called once per frame
void OnTriggerEnter(Collider other)
{
    if (other.tag == "Player")
    {
        anim.SetTrigger("DoorOpen");
        if (!creakNoise.isPlaying)
        {
            creakNoise.Play();
        }

    }

}
}
