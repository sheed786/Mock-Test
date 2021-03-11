using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
   public void Play()//creating function
    {
        SceneManager.LoadScene("Game");//loading scene
    }
    public void Controls()//creating function
    {
        SceneManager.LoadScene("Controls");//loading scene
    }
    public void Quit()//creating function
    {
        Application.Quit();//loading scene
    }
    public void Back()//creating function
    {
        SceneManager.LoadScene("Menu");//loading scene
    }
    public void Restart()//creating function
    {
        SceneManager.LoadScene("Game");//loading scene
    }
   

}
