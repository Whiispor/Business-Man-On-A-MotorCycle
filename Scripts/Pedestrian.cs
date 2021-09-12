using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedestrian : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "pedestrian";
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "aa")
        {
            Destroy(gameObject);
            Score.score -= 5;
        }
    }
}
