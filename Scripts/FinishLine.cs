using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "aa")
        {
            Score.gameRunning = false;
            //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //  Debug.Log("Hit");
        }
    }
}
