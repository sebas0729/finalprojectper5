using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Play() => SceneManager.LoadScene("Game"); // One-line functions can use "=>"

    public void Quit()
    {
        Application.Quit(); // Quits the game when in a standalone build version of the game.

    }
}
