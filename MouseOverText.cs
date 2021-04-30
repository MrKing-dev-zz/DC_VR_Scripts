using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MouseOverText : MonoBehaviour
{

    public Text description;
    public GameObject descObj;

    void Start()
    {
        descObj.SetActive(false);
    }

    // Update is called once per frame
    void OnMouseOver()
    {
        description.text = this.name;
        
        descObj.SetActive(true);

    }

    private void OnMouseExit()
    {
        descObj.SetActive(false);
    }
}
