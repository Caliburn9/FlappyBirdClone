using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    public static int displayedScore;
    public GameManager gameManager;

    private void Start()
    {
        displayedScore = 0;
    }

    private void Update()
    {
        displayedScore = gameManager.score;
        GetComponent<TMPro.TextMeshProUGUI>().text = displayedScore.ToString();
    }
}
