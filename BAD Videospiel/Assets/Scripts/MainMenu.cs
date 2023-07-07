using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Kann auf der Scenen Name angegeben werden
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player has Quit the Game");
    }
}
