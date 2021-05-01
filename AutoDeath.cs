using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDeath : MonoBehaviour
{

    public float killTime;
    public float killDistance;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(KillInTime());
    }

    
    IEnumerator KillInTime()
    {
        while (1 == 1)
        {

            yield return new WaitForSeconds(killTime);
            player = GameObject.FindWithTag("Player");
            if (Vector3.Distance(transform.position, player.transform.position) > killDistance)
            {
                Destroy(gameObject);
            }

        }

    }
}
