using UnityEngine;

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

    bool PauseGame = false;
    public BoolObject PauseMenuActive;

    private void Start()
    {
        HealthAndStaminaUI.enabled = true;
        PauseMenuUI.enabled = false;
        OptionsUI.enabled = false;
        PauseGame = false;
        QuitUI.enabled = false;
    }

    private void Update()
    {
        if (Input.GetButtonUp("PauseMenu"))
        {
            Debug.Log("work");
            switch (PauseGame)
            {
                case true:
                    ShowHealthAndStaminaUI();
                    Time.timeScale = 1;
                    PauseGame = false;
                    PauseMenuActive.value = false;
                    break;
                case false:
                    ShowPauseMenu();
                    Time.timeScale = 0;
                    PauseGame = true;
                    PauseMenuActive.value = true;

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
        OptionsUI.enabled = false;
        QuitUI.enabled = false;
    }
}
