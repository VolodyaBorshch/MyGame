using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    [SerializeField] GameObject _pauseMenu;

    // Start is called before the first frame update
    public bool PauseGame;
    public GameObject pauseGameMenu;

    WindowManager windowManager;

	private void Awake()
	{
        windowManager = FindObjectOfType<WindowManager>();
	}

	// Update is called once per frame
	void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    
    public void Resume()
    {
        windowManager.OpenWindow(_pauseMenu);
        Time.timeScale = 1f;
        PauseGame = false;
    }
    public void Pause()
    {
        Time.timeScale = 0f;
        PauseGame = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void LoadOption()
    {
        
    }
}
