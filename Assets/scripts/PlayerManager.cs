using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public static bool isLevelOver;
    
    public GameObject gameOverScreen;
    public GameObject pauseMenuScreen;
    public GameObject levelOverScreen;
    
    private void Awake()
    {
        isGameOver = false;
        isLevelOver = false;
        
    }

   /* private void Start()
    {
        isLevelOver = false;
    }*/

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
        }
        if (isLevelOver)
        {
            levelOverScreen.SetActive(true);
        }
        
    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // This will activate replay button command
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseMenuScreen.SetActive(true);
        // This will Activate when pause button is clicked
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseMenuScreen.SetActive(false);
        // This will Activate when resume button is clicked
    }

    public void NextLevel()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // this will Activate when you complete a desired score
    }
}
