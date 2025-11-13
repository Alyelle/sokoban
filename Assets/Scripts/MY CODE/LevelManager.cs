using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour
{

    public int buttonsPressed;
    public int buttonsNeeded;

    private Scene currentScene;
    private string sceneName;

   
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buttonsPressed = 0;

        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;

        if (sceneName == "Level1")
        {
            buttonsNeeded = 3;
        }
        else if (sceneName == "Level2")
        {
            buttonsNeeded = 3;
        }
        else if (sceneName == "Level3")
        {
            buttonsNeeded = 5;
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (buttonsPressed == buttonsNeeded)
        {
            if (sceneName == "Level1")
            {
                buttonsPressed = 0;
                SceneManager.LoadScene("Level2");
            }
            else if (sceneName == "Level2")
            {
                buttonsPressed = 0;
                SceneManager.LoadScene("Level3");
            }
            else if (sceneName == "Level3")
            {
                buttonsPressed = 0;
                SceneManager.LoadScene("Start");
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(currentScene.name);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Start");
        }

    }

}