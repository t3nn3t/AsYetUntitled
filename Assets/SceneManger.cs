using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManger : MonoBehaviour
{
    private bool gameOver = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void SpaceRestart()
    {
        if (gameOver)
        {
            RestartLevel();
        }
    }

    public void GameOver()
    {
        gameOver = true;
    }

    public bool IsGameOver()
    {
        return gameOver;
    }
}
