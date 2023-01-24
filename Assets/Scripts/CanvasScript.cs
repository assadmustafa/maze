using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CanvasScript : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None; // Unlocks the cursor from the middle of the screen
        Cursor.visible = true; // Makes the cursor visible
    }

    public void Level1() // Method for play button
    {
        SceneManager.LoadScene("Level 1"); // Load Level 1 scene
    }

    public void Level2() // Method for play button
    {
        SceneManager.LoadScene("Level 2"); // Load Level 1 scene
    }

    public void Level3() // Method for play button
    {
        SceneManager.LoadScene("Level 3"); // Load Level 1 scene
    }

    public void Level4() // Method for play button
    {
        SceneManager.LoadScene("Level 4"); // Load Level 1 scene
    }

    public void Level5() // Method for play button
    {
        SceneManager.LoadScene("Level 5"); // Load Level 1 scene
    }

    public void Level6() // Method for play button
    {
        SceneManager.LoadScene("Level 6"); // Load Level 1 scene
    }

    public void Level7() // Method for play button
    {
        SceneManager.LoadScene("Level 7"); // Load Level 1 scene
    }


    public void PressQuit() // Method for quit Button
    {
        Application.Quit(); // Quits the game
    }

}