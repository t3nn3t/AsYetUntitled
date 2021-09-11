using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public List<GameObject> Children;

    //0 for playing, 1 for game over, 2 for waiting
    private int gameOver = 0;

    public ScoreText st;
    public SceneManger sm;

    void Start()
    {
        foreach (Transform child in transform)
        {
            if (child.tag == "Enemy")
            {
                Children.Add(child.gameObject);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        CheckWinCondition();

        if (gameOver==1)
        {
            sm.GameOver();
            st.GameOver();
            gameOver = 2;
        }
    }

    private int CheckWinCondition()
    {
        foreach (GameObject child in Children)
        {
            if (child != null)
            {
                return 0;
            }
        }
        gameOver = 1;
        return 1;
    }
}
