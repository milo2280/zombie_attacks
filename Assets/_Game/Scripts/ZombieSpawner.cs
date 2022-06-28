using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject theZombie;
    private GameObject spawnedZombie;

    public Transform[] spawnPos;

    private Coroutine gameCoroutine = null;

    void Start()
    {
        gameCoroutine = StartCoroutine(SpawnZombies());
    }

    IEnumerator SpawnZombies()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 3));

            spawnedZombie = Instantiate(theZombie);

            int random = Random.Range(0, 8);

            spawnedZombie.transform.position = spawnPos[random].position;
        }
    }

    public void StopCoroutine()
    {
        if (gameCoroutine != null)
            StopCoroutine(gameCoroutine);
    }
}
