using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Canvas QuitMenu;
    public Button ButtonStart;
    public Button ButtonExit;

    private Canvas menuUI;

    private void Start()
    {
        menuUI = GetComponent<Canvas>();
        QuitMenu = QuitMenu.GetComponent<Canvas>();
        ButtonStart = ButtonStart.GetComponent<Button>();
        ButtonExit = ButtonExit.GetComponent<Button>();

        QuitMenu.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            menuUI.enabled = !menuUI.enabled;
        }
    }

    public void ExitGameButton()
    {
        QuitMenu.enabled = true;
        ButtonStart.enabled = false;
        ButtonExit.enabled = false;
    }

    public void DontLeaveGameButton()
    {
        QuitMenu.enabled = false;
        ButtonStart.enabled = true;
        ButtonExit.enabled = true;
    }

    public void StartGameButton()
    {
        SceneManager.LoadScene("ChessGame");
    }

    public void ExitGameButtonYes()
    {
        Application.Quit();
    }
}
