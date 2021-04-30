using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnterAreaText : MonoBehaviour
{

    public Text description;
    public GameObject descObj;

    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        description = GameObject.Find("HUDCanvas").GetComponent<HUDVariables>().description;
        descObj = GameObject.Find("HUDCanvas").GetComponent<HUDVariables>().descObj;

        if (other.tag == "Player")
        {
            description.text = this.name;

            descObj.SetActive(true);
        }
        

    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            descObj.SetActive(false);

        }

    }
}
