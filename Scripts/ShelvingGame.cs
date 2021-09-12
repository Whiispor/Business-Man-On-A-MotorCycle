using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShelvingGame : MonoBehaviour
{
    public static string[] boxes;
    private string randomBox;
    private string[] boxOptions = new string[] { "red", "blue", "green", "yellow" };
    public static int boxNum = 0;
    public Transform red;
    public Transform blue;
    public Transform green;
    public Transform yellow;
    private Transform clone;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        boxes = new string[] { boxOptions[UnityEngine.Random.Range(0, 4)], boxOptions[UnityEngine.Random.Range(0, 4)], boxOptions[UnityEngine.Random.Range(0, 4)], boxOptions[UnityEngine.Random.Range(0, 4)], boxOptions[UnityEngine.Random.Range(0, 3)], boxOptions[UnityEngine.Random.Range(0, 3)], boxOptions[UnityEngine.Random.Range(0, 3)], boxOptions[UnityEngine.Random.Range(0, 3)], boxOptions[UnityEngine.Random.Range(0, 3)], boxOptions[UnityEngine.Random.Range(0, 3)] };
        float index = 0f;
        foreach (string box in boxes)
        {
            if (box == "red")
            {
                clone = Instantiate(red, new Vector3(19.211f + index * 2, 0.575f, 2.241f), Quaternion.identity);
            }
            if (box == "blue")
            {
                clone = Instantiate(blue, new Vector3(19.211f + index * 2, 0.575f, 2.241f), Quaternion.identity);
            }
            if (box == "green")
            {
                clone = Instantiate(green, new Vector3(19.211f + index * 2, 0.575f, 2.241f), Quaternion.identity);
            }
            if (box == "yellow")
            {
                clone = Instantiate(yellow, new Vector3(19.211f + index * 2, 0.575f, 2.241f), Quaternion.identity);
            }
            clone.tag = index.ToString();
            index += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (boxNum == 10)
        {
            Finish();
        }
    }
    void Finish()
    {
        score.text = $"Score: {(ShelfLabel.shelvingScore / 10 * 100).ToString()}%";
        Home.money += ShelfLabel.shelvingScore * 20;
        Invoke("NextScene", 5);
    }
    void NextScene()
    {
        SceneManager.LoadScene(3);
    }
}
