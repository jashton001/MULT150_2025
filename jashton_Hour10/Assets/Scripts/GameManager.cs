using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; 

public class GameManager : MonoBehaviour
{
    public GameObject playAgainButton;
    public TMP_Text timerText; 

    public GoalScript blue, green, red, orange;

    private bool isGameOver = false;
    private float startTime;
    private bool isRunning = true; 

    // Start is called before the first frame update
    void Start()
    {
        // Initialize timer state 
        startTime = Time.time;
        isRunning = true;
        isGameOver = false; 

        // Ensure the Play Again button is hidden when the game starts
        if(playAgainButton)
        {
            playAgainButton.SetActive(false); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(isRunning && timerText != null)
        {
            float t = Time.time - startTime;
            string minutes = ((int)t / 60).ToString("00");
            string seconds = (t % 60).ToString("00.00");

            timerText.text = "Time: " + minutes + ":" + seconds;
        }

        // If all four goals are solved then the game is over
        bool hasWon = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;
        
        // Use a conditional to run the "end game" logic only once
        if(hasWon && !isGameOver)
        {
            isGameOver = true;
            EndGame(); // Call a method to handle all end-game actions
        }
    }

    public void EndGame()
    {
        isRunning = false;

        if (timerText != null)
        {
            timerText.text = "Winner! Final " + timerText.text; 
        }

        if (playAgainButton)
        {
            // Make the button visible when the game ends
            playAgainButton.SetActive(true);
        }
    }

    public void RestartGame()
    {
        //Reloads the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void OnGUI ()
    {
        if(isGameOver)
        {
            //This draws the "Game Over" box and label
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
            GUI.Box(rect, "Game Over");

            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
            GUI.Label(rect2, "Good Job!");

        }
    }
}
