using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Minigame_Movement : MonoBehaviour
{
    public float speed = 0.5f;
    public static float score = 0;
    public static bool stillAlive = true;
    // Start is called before the first frame update

    void Awake()
    {
        score = 0;
        stillAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (PauseMenu.GameIsPaused)
        {
            speed = 0f;
        }
        else
        {
            speed = 0.5f;
        }
        transform.position += new Vector3(Input.GetAxis("Horizontal") * speed, 0, 0);
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, -6.0f, 6.0f);
        transform.position = clampedPosition;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        stillAlive = false;
        SceneManager.LoadScene(3);
        Home.money += score * 10;
    }
}
