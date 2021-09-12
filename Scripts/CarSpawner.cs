using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CarSpawner : MonoBehaviour
{
    public float delay = 0.5f;
    public GameObject cube;
    public Transform target;
    private GameObject clonedObject;
    private bool safeSpawn;
    void Start()
    {
        InvokeRepeating("Spawn", delay, delay);
    }
    void Spawn()
    {
        if (target.position.z < 450 && Score.gameRunning)
        {
            Vector3 randomPos = new Vector3(UnityEngine.Random.Range(-4.22f, 4.69f), 2.55f, UnityEngine.Random.Range(target.position.z + 30.0f, target.position.z + 50.0f));
            Collider[] colliders = Physics.OverlapSphere(randomPos, 3.0f);
            foreach (Collider hit in colliders)
            {
                if (hit.tag != "car")
                {
                    safeSpawn = true;
                }
                else
                {
                    safeSpawn = false;
                }
            }
            if (safeSpawn)
            {
                clonedObject = Instantiate(cube, new Vector3(randomPos.x, randomPos.y, randomPos.z), Quaternion.identity);
                clonedObject.tag = "car";
            }
            //foreach (Collider hit in colliders)
            //{
            //    if (!hit)
            //    {
            //        Instantiate(cube, new Vector3(randomPos.x, randomPos.y, randomPos.z), Quaternion.identity);
            //    }
            //    else
            //    {
            //        Spawn();
            //    }
            //}

        }
    }
}