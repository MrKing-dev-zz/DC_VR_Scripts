using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DragonAttack : MonoBehaviour
{


    Animator anim;
    public AudioSource attackSound;
    public AudioSource wingSound;
    public AudioSource landSound;
    public NavMeshAgent agent;




    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        agent = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
           agent.destination = other.transform.position;
            anim.SetBool("Chilling", false);
            transform.LookAt(other.transform);


        }

    }
    public void DragonSound()
    {

        attackSound.Play();

    }

    public void WingPlay()
    {
        if(wingSound.isPlaying == false)
        {
            wingSound.Play();
        }
        else
        {
            wingSound.Stop();
        }
        
    }
    
   

    public void LandPlay()
    {
        landSound.Play();
    }



    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(GoToSleep());

        }
    }

    IEnumerator GoToSleep()
    {
        yield return new WaitForSeconds(5);
        agent.ResetPath();

        anim.SetBool("Chilling", true);

    }
}
