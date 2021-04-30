using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowPlayer : MonoBehaviour
{

    public void Start()
    {
        //transform.eulerAngles = new Vector3(transform.eulerAngles.x, Random.Range(0, 360), transform.eulerAngles.z);
        //float speed = 1200;
        //rb.isKinematic = false;
        //Vector3 force = transform.forward;
        //force = new Vector3(force.x, 1, force.z);
        //rb.AddForce(force * speed);
        var rb = GameObject.Find("PlayerOne").GetComponent<Rigidbody>();
        rb.AddForce(Random.Range(15, 75), Random.Range(5, 20), Random.Range(15, 75), ForceMode.Impulse);
    }
}
