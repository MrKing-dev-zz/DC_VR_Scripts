using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceTestScript : MonoBehaviour
{

    public float thrust = 1.0f;
    public Rigidbody rb;

    // Start is called before the first frame update
    public void Acceleration()
    {
        rb.AddForce(transform.forward * thrust);
    }

    public void Impulse()
    {
        rb.AddForce(0, 0, thrust, ForceMode.Impulse);
    }

    public void Throw()
    {
        //transform.eulerAngles = new Vector3(transform.eulerAngles.x, Random.Range(0, 360), transform.eulerAngles.z);
        //float speed = 600;
        //rb.isKinematic = false;
        //Vector3 force = transform.forward;
        //force = new Vector3(force.x, 1, force.z);
        //rb.AddForce(force * speed);
        rb.AddForce(Random.Range(50, 75), Random.Range(15, 30), Random.Range(50, 75), ForceMode.Impulse);
    }

}
