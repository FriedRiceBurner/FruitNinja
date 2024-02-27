using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuCanvas;

    public bool isActive = true;
    // Start is called before the first frame update
    void Start()
    {
        DisplayPauseMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseButtonPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            DisplayPauseMenu();
        }
    }
    public void DisplayPauseMenu()
    {
        Time.timeScale = Time.timeScale == 0 ? 1 : 0; 
        pauseMenuCanvas.SetActive(!isActive);
        isActive = !isActive;
    }

    public void ResumeGame()
    {
        DisplayPauseMenu(); // toggle pause button
    }
    public static void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public static void QuitGame()
    {
        //If we are running in a standalone build of the game
        #if UNITY_STANDALONE
        //Quit the application
        Application.Quit();
        #endif

        //If we are running in the editor
        #if UNITY_EDITOR
        //Stop playing the scene
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
