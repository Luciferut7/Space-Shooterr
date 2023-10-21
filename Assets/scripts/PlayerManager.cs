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
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseMenuScreen.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseMenuScreen.SetActive(false);
    }

    public void NextLevel()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
