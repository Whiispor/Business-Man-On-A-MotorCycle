using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float delay = 1.0f;
    public GameObject cube;
    public Transform target;
    void Start()
    {
        InvokeRepeating("Spawn", delay, delay);
    }
    void Spawn()
    {
        if (target.position.z < 450 && Score.gameRunning)
        {
            Instantiate(cube, new Vector3(Random.Range(-4.22f, 4.69f), 2.55f, Random.Range(target.position.z + 30.0f, target.position.z + 50.0f)), Quaternion.identity);
        }
    }
}