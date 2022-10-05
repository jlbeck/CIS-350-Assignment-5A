using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayScore : MonoBehaviour
{
    public static bool gameOver;
    public static bool won;
    public static int score;

    public Text textbox;

    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {

        //If the game is not over, display score
        if (!gameOver)
        {
            textbox.text = "Score: " + score;
        }


        if (gameOver)
        {
            textbox.text = "You win!";
        }

    }
}
