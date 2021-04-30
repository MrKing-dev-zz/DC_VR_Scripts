using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityAttack : MonoBehaviour
{
    
    
    Animator anim;
    public AudioSource attackSound;
    


    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetTrigger("ZombAttack");
            transform.LookAt(other.transform);
            if(!attackSound.isPlaying)
            {
                attackSound.Play();
            }
                                  
        }

    }
    
}
