using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class SetEnemyDest : MonoBehaviour
{

    public NavMeshAgent agent;
    public GameObject dest;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = dest.transform.position;
    }
}
