using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject nextLevel;

    public void Start()
    {
        Application.targetFrameRate = 300;

    }
    public void GameOver()
    {
        gameOver.gameObject.SetActive(true);
    }

    public void NextLevel()
    {
        nextLevel.gameObject.SetActive(true);
    }
}
