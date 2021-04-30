using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeFader : MonoBehaviour
{

    public int treeDist;
    public GameObject HUD;
    // Start is called before the first frame update
    void Start()
    {
        Terrain.activeTerrain.treeDistance = 2000;
        HUD.gameObject.SetActive(false);
        StartCoroutine(TreeFadeInTime());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TreeFadeInTime()
    {
        yield return new WaitForSeconds(14);
        Terrain.activeTerrain.treeDistance = treeDist;
        HUD.gameObject.SetActive(true);
        //RenderSettings.fog = true;
    }
}
