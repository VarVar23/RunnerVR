using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController 
{
    public MenuController(MenuView menuView)
    {
        menuView.InitStart(ButtonStart);
        menuView.InitExit(ButtonExit);
    }

    private void ButtonStart()
    {
        SceneManager.LoadScene(1);
    }

    private void ButtonExit()
    {
        Application.Quit();
    }
}
