using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverCanvas;
    public int score = 0;

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void gameOver ()
    {
        gameoverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void gameRestart()
    {
        SceneManager.LoadScene(0);
    }
}
