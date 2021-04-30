using UnityEngine;

public class LeaderboardTestGUI : MonoBehaviour
{
    private string _nameInput = "Name Input";
    private int _scoreInput;
    public GUIStyle HeaderStyle;
    public GUIStyle ScoreStyle;
    public GUISkin LeaderboardSkin;

    private void Start()
    {
        this.gameObject.SetActive(false);
    }

    private void OnGUI()
    {
        GUI.skin = LeaderboardSkin;
        _scoreInput = GameControl.control.playerscore;
     
        GUILayout.BeginArea(new Rect(480, 0, 960, Screen.height));

        GUILayout.Label("High Scores", HeaderStyle); // Display the header
        GUILayout.Space(20);

        // Display high scores!
        for (int i = 0; i < Leaderboard.EntryCount; ++i)
        {
            var entry = Leaderboard.GetEntry(i);
            GUILayout.Label("Name: " + entry.name + ", Score: " + entry.score);
        }

        // Interface for reporting test scores.
        GUILayout.Space(10);

        _nameInput = GUILayout.TextField(_nameInput);
        //_scoreInput = GUILayout.TextField(_scoreInput);
        GUILayout.Label("Current Score:  " + _scoreInput.ToString(), ScoreStyle);

        if (GUILayout.Button("Record"))
        {
            int score;
            int.TryParse(_scoreInput.ToString(), out score);

            Leaderboard.Record(_nameInput, score);

            // Reset for next input.
            _nameInput = "Name Input";
            _scoreInput = GameControl.control.playerscore;
        }

        if (GUILayout.Button("Clear"))
        {
            Leaderboard.Clear();
        }

        GUILayout.EndArea();
    }
}
