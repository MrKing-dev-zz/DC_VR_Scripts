using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderBoardControl : MonoBehaviour
{

    public GameObject Leaderboard;
    
    // Start is called before the first frame update
    public void runLeaderboard()
    {
        Leaderboard.SetActive(true);
    }

    // Update is called once per frame
    public void goBack()
    {
        Leaderboard.SetActive(false);
    }
}
