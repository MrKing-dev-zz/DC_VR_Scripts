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
        if (explode)
        {
            rb.AddExplosionForce(expForce, expPos.transform.position, expRadius, expUP, ForceMode.Acceleration);

        }

    }
}
