using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckPoint : MonoBehaviour
{
    public Transform chracter;
    
    private Vector3 spawnPoint;
    void Start()
    {
        
    }
    void Update()
    {	//death area ile bu sorunu çözdüm.S
        if (chracter.transform.position.y < -0.1f)
        {
            //chracter.position = spawnPoint;
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Checkpoint"))
        {
            spawnPoint = other.transform.position;
            
        }
        if (other.gameObject.CompareTag("Death"))
        {
            spawn();

        }
        
    }
    private void spawn()
    {
        chracter.position = spawnPoint;
    }
}
