using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    public float speed = 10.0f;
    public static float redShelf = 0f;
    public static float blueShelf = 0f;
    public static float greenShelf = 0f;
    public static float yellowShelf = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (tag == ShelvingGame.boxNum.ToString())
        {
            if (!ShelfLabel.boxMove)
            {
                float step = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(0.3f, transform.position.y, transform.position.z), step);
            }
            if (ShelfLabel.boxMove)
            {
                if (ShelfLabel.selection == "red")
                {
                    float step = speed * Time.deltaTime;
                    transform.position = Vector3.MoveTowards(transform.position, new Vector3(-5 + redShelf, 7, 8), step);
                    if (transform.position == new Vector3(-5 + redShelf, 7, 8))
                    {
                        if (ShelfLabel.correct)
                        {
                            ShelfLabel.shelvingScore += 1;
                        }
                        ShelfLabel.boxMove = false;
                        ShelvingGame.boxNum += 1;
                        ShelfLabel.selection = "";
                    }

                }
                if (ShelfLabel.selection == "blue")
                {
                    float step = speed * Time.deltaTime;
                    transform.position = Vector3.MoveTowards(transform.position, new Vector3(-5 + blueShelf, 5, 8), step);
                    if (transform.position == new Vector3(-5 + blueShelf, 5, 8))
                    {
                        if (ShelfLabel.correct)
                        {
                            ShelfLabel.shelvingScore += 1;
                        }
                        ShelfLabel.boxMove = false;
                        ShelvingGame.boxNum += 1;
                        ShelfLabel.selection = "";
                    }

                }
                if (ShelfLabel.selection == "green")
                {
                    float step = speed * Time.deltaTime;
                    transform.position = Vector3.MoveTowards(transform.position, new Vector3(-5 + greenShelf, 3, 8), step);
                    if (transform.position == new Vector3(-5 + greenShelf, 3, 8))
                    {
                        if (ShelfLabel.correct)
                        {
                            ShelfLabel.shelvingScore += 1;
                        }
                        ShelfLabel.boxMove = false;
                        ShelvingGame.boxNum += 1;
                        ShelfLabel.selection = ""; ;
                    }

                }
                if (ShelfLabel.selection == "yellow")
                {
                    float step = speed * Time.deltaTime;
                    transform.position = Vector3.MoveTowards(transform.position, new Vector3(-5 + yellowShelf, 1, 8), step);
                    if (transform.position == new Vector3(-5 + yellowShelf, 1, 8))
                    {
                        if (ShelfLabel.correct)
                        {
                            ShelfLabel.shelvingScore += 1;
                        }
                        ShelfLabel.boxMove = false;
                        ShelvingGame.boxNum += 1;
                        ShelfLabel.selection = "";
                    }

                }
            }
        }
    }
}
