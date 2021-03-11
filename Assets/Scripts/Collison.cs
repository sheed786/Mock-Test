using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//to work with different scenes

public class Collison : MonoBehaviour
{
    float LoadDelay = 1f; //time taken to load scene

   

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debugkey();// calling a function
    }

    void Debugkey()//creatong a new function
    {
        if (Input.GetKeyDown(KeyCode.L))//geting input key
        {
            LoadLevel();//calling a function
        }
    }
    void OnCollisionEnter(Collision other)//using collision to check the object is colliding or not
    {
       
        switch (other.gameObject.tag)
        {
            case "Danger":
                hitted();//calling a function
                break;
            case "End":
                ended();//caliing a function
                break;

        }

    }
    void hitted()
    {
        GetComponent<PlayerMovement>().enabled = false;//if he get hits the movement will disabled
        Invoke("ReLoadLevel", LoadDelay);//loading current scene
    }
    void ended()
    {
        GetComponent<PlayerMovement>().enabled = false;//if he get hits the movement will disabled
        Invoke("LoadLevel", LoadDelay);//loading next scene
    }
    void ReLoadLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;//buildindex returns the index of the scene
        SceneManager.LoadScene(currentScene);//loading next scene or current scene
    }

    void LoadLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;//buildindex returns the index of the scene
        SceneManager.LoadScene(currentScene +1);//loading next scene or current scene
    }


}
   

