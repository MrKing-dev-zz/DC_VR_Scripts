using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFlames : MonoBehaviour
{

    public ParticleSystem ps;
    public GameObject FlameArea;
    public Rigidbody rb;
    public float expForce;
    public GameObject expPos;
    public float expRadius;
    public float expUP;
    bool explode = false;
    /*public int hormax;
    public int hormin;
    public int vertmax;
    public int vertmin;
    */
    // Start is called before the first frame update
    void Start()
    {
        var psmain = ps.main;
        ps.Stop();
        rb = GameObject.Find("PlayerOne").GetComponent<Rigidbody>();
        
    }

    public void FlameOn()
    {
        FlameArea.SetActive(true);
        explode = true;
        ps.Play();
    }

    public void FlameOff()
    {
        FlameArea.SetActive(false);
        ps.Stop();
        explode = false;
    }

    public void FixedUpdate()
    {
        /*transform.eulerAngles = new Vector3(transform.eulerAngles.x, Random.Range(0, 360), transform.eulerAngles.z);
        float speed = 600;
        rb.isKinematic = false;
        Vector3 force = transform.forward;
        force = new Vector3(force.x, 1, force.z);
        rb.AddForce(force * speed);
        */
        //rb.AddForce(Random.Range(hormin, hormax), Random.Range(vertmin, vertmax), Random.Range(hormin, hormax), ForceMode.Impulse);
        if (explode)
        {
            rb.AddExplosionForce(expForce, expPos.transform.position, expRadius, expUP, ForceMode.Acceleration);

        }

    }
}
