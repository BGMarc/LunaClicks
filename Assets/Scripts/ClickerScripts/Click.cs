using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public static int clickValue;
    public static int amountPerSecond;
    private void Start()
    {
        //sets the initial click value to 1
        clickValue = 1;
    }
    public void ClickerButton()
    {
        //makes the clicker button change both the score and the high score (for the moon)
        ScoreManager.score+=clickValue;
        ScoreManager.HighScore += clickValue;
        ScoreManager.Increase();
    }
    public void Update()
    {
        // creates a hotkey to press the button when you press thew space button
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ScoreManager.score += clickValue;
            ScoreManager.HighScore += clickValue;
            ScoreManager.Increase();
        }
    }


}
