using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDeath : MonoBehaviour
{

    public float KillTime;
    public float KillDistance;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(KillInTime());
    }

    
    IEnumerator KillInTime()
    {
        while (1 == 1)
        {

            yield return new WaitForSeconds(KillTime);
            Player = GameObject.FindWithTag("Player");
            if (Vector3.Distance(transform.position, Player.transform.position) > KillDistance)
            {
                Destroy(gameObject);
            }

        }

    }
}
