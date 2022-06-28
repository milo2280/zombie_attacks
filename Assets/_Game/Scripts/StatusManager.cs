using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusManager : MonoBehaviour
{
    public static StatusManager instance;

    public Text scoreText;
    public Text levelText;
    public Text healthText;

    int score = 0;
    int level = 1;
    int health;

    private void Awake()
    {
        instance = this;
        health = FindObjectOfType<PlayerHealthManager>().health;
    }

    void Start()
    {
        scoreText.text = "Points: " + score.ToString();
        levelText.text = "Level: " + level.ToString();
        healthText.text = "Health: " + health.ToString();
    }

    public void AddPoint()
    {
        score++;
        scoreText.text = "Points: " + score.ToString();
    }

    public void AddLevel()
    {
        if (score % 5 == 0)
        {
            level++;
            levelText.text = "Level: " + level.ToString();
        }
    }

    public void MinusHealth()
    {
        health--;
        healthText.text = "Health: " + health.ToString();
    }
}
