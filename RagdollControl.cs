using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollControl : MonoBehaviour
{
    public List<Collider> RagdollParts = new List<Collider>();
    public Rigidbody rb;
    public Animator animator;
    
    // Start is called before the first frame update
    private void Awake()
    {
        SetRagdollParts();
    }

    private void SetRagdollParts()
    {
        Collider[] colliders = this.gameObject.GetComponentsInChildren<Collider>();

        foreach(Collider c in colliders)
        {
            if (c.gameObject != this.gameObject)
            {
                if (c.gameObject.tag  != "Vital" )
                {
                    c.isTrigger = true;
                    RagdollParts.Add(c);
                }
                
            }
            
        }
    }

    public void TurnOnRagdoll()
    {
        rb.AddForce(300f * Vector3.up);
        rb.useGravity = false;
        rb.velocity = Vector3.zero;
        this.gameObject.GetComponent<CapsuleCollider>().enabled = false;
        animator.enabled = false;
        //animator.avatar = null;
        


        foreach (Collider c in RagdollParts)
        {
            c.isTrigger = false;
            c.attachedRigidbody.velocity = Vector3.zero;
        }
    }

    public void TurnOffRagdoll()
    {
        rb.useGravity = true;
        //rb.velocity = Vector3.zero;
        this.gameObject.GetComponent<CapsuleCollider>().enabled = true;
        animator.enabled = true;
        //animator.avatar = null;



        foreach (Collider c in RagdollParts)
        {
            c.isTrigger = true;
            //c.attachedRigidbody.velocity = Vector3.zero;
        }
    }
}
