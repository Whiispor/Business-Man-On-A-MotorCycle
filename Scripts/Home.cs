using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    public static float money = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void NextDay()
    {
        SceneManager.LoadScene(1);
    }
    public void Shop()
    {
        Debug.Log("Shop");
        Debug.Log($"You have {money} money");
    }
}
