using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfLabel : MonoBehaviour
{
    public static string selection;
    public static float shelvingScore;
    public static bool boxMove;
    public static bool correct;
    // Start is called before the first frame update
    void Start()
    {
        selection = "";
        boxMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Shelf Label Red")
                {
                    selection = "red";
                    box.redShelf += 1;
                }
                else if (hit.transform.name == "Shelf Label Blue")
                {
                    selection = "blue";
                    box.blueShelf += 1;
                }
                else if (hit.transform.name == "Shelf Label Green")
                {
                    selection = "green";
                    box.greenShelf += 1;
                }
                else if (hit.transform.name == "Shelf Label Yellow")
                {
                    selection = "yellow";
                    box.yellowShelf += 1;
                }
            }
        }
        if (selection != "")
        {
            if (selection == ShelvingGame.boxes[ShelvingGame.boxNum])
            {
                Correct();
            }
            else
            {
                Incorrect();
            }
        }
    }
    void Correct()
    {
        correct = true;
        Debug.Log("Correct");
        boxMove = true;

    }
    void Incorrect()
    {
        correct = false;
        Debug.Log("Incorrect");
        boxMove = true;
    }
}
