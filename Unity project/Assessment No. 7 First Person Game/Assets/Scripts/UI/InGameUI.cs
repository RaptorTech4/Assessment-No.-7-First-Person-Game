using UnityEngine;
using UnityEngine.SceneManagement;


public class InGameUI : MonoBehaviour
{

    [SerializeField]
    Canvas HealthAndStaminaUI;
    [SerializeField]
    Canvas PauseMenuUI;
    [SerializeField]
    Canvas OptionsUI;
    [SerializeField]
    Canvas QuitUI;
    [SerializeField]
    Canvas PagesUI;

    bool PauseGame = false;
    bool PagesActive = false;
    public BoolObject PauseMenuActive;

    private void Start()
    {
        //----UI----
        HealthAndStaminaUI.enabled = true;
        PauseMenuUI.enabled = false;
        OptionsUI.enabled = false;
        QuitUI.enabled = false;
        PagesUI.enabled = false;
        //----UI----

        PauseGame = false;
        PauseMenuActive.value = false;

        PagesActive = false;

        MouseToggel();
    }

    private void Update()
    {
        if (Input.GetButtonUp("PauseMenu"))
        {
            switch (PauseGame)
            {
                case true:
                    ShowHealthAndStaminaUI();
                    Time.timeScale = 1;
                    PauseGame = false;
                    PauseMenuActive.value = false;
                    MouseToggel();
                    break;
                case false:
                    ShowPauseMenu();
                    Time.timeScale = 0;
                    PauseGame = true;
                    PauseMenuActive.value = true;
                    MouseToggel();
                    break;
            }
        }

        if(Input.GetButtonUp("Page"))
        {
            switch (PagesActive)
            {
                case true:
                    DeactivateAllUI();
                    PauseMenuActive.value = false;
                    MouseToggel();
                    PagesActive = false;
                    ShowHealthAndStaminaUI();
                    break;
                case false:
                    DeactivateAllUI();
                    PauseMenuActive.value = true;
                    MouseToggel();
                    PagesUI.enabled = true;
                    PagesActive = true;
                    break;
            }
        }
    }

    private void ShowPauseMenu()
    {
        DeactivateAllUI();
        PauseMenuUI.enabled = true;
    }

    public void ResumeGame()
    {
        ShowHealthAndStaminaUI();
        Time.timeScale = 1;
        PauseGame = false;
        PauseMenuActive.value = false;
        MouseToggel();
    }

    private void ShowHealthAndStaminaUI()
    {
        DeactivateAllUI();
        HealthAndStaminaUI.enabled = true;
    }

    private void DeactivateAllUI()
    {
        HealthAndStaminaUI.enabled = false;
        PauseMenuUI.enabled = false;
        PagesUI.enabled = false;
        OptionsUI.enabled = false;
        QuitUI.enabled = false;
    }

    private void MouseToggel()
    {
        switch (PauseMenuActive.value)
        {
            case false:
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                break;
            case true:
                Cursor.lockState = CursorLockMode.Confined;
                Cursor.visible = true;
                break;
        }
    }

    public void HidePages()
    {
        DeactivateAllUI();
        PauseMenuActive.value = false;
        MouseToggel();
        PagesActive = false;
        ShowHealthAndStaminaUI();
    }

    public void QuitToMainMenu()
    {
        PauseMenuActive.value = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

    public void QuitToDesctop()
    {
        Application.Quit();
    }
}
