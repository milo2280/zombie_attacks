using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealthManager : MonoBehaviour
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
            StatusManager.instance.AddPoint();
            StatusManager.instance.AddLevel();
            Destroy(gameObject);
        }
    }

    public void HurtZombie(int damage)
    {
        currentHealth -= damage;
    }
}
