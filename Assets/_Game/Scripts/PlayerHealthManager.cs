using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour
{
    public int health;
    private int currentHealth;

    void Start()
    {
        currentHealth = health;
    }


    void Update()
    {
        if (currentHealth <= 0)
        {
            FindObjectOfType<GameManager>().GameOver();
            FindObjectOfType<ZombieSpawner>().StopCoroutine();
        }
    }

    public void HurtPlayer(int damageAmount)
    {
        currentHealth -= damageAmount;
        StatusManager.instance.MinusHealth();
    }
}
