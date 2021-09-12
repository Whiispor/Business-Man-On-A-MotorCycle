using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame_Spawner : MonoBehaviour
{
    public float delay = 1.0f;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", delay, delay);
    }

    void Spawn()
    {
        Instantiate(cube, new Vector3(Random.Range(-6, 6), 10, 0), Quaternion.identity);
        Minigame_Movement.score += 1;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
