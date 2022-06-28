using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    private Rigidbody myRG;
    public float moveSpeed;

    public PlayerController thePlayer;

    void Start()
    {
        myRG = GetComponent<Rigidbody>();
        thePlayer = FindObjectOfType<PlayerController>();
    }

    private void FixedUpdate()
    {
        myRG.velocity = transform.forward * moveSpeed;
    }

    void Update()
    {
        transform.LookAt(thePlayer.transform.position);
    }
}
