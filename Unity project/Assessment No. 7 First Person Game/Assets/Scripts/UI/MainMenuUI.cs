using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuUI : MonoBehaviour
{

    [SerializeField]
    Canvas MainMenuCanvas;
    [SerializeField]
    Canvas OptionsCanvas;
    [SerializeField]
    Canvas QuitCanvas;

    private void Start()
    {
        MainMenuCanvas.enabled = true;
        OptionsCanvas.enabled = false;
        QuitCanvas.enabled = false;
    }

    public void Play()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
