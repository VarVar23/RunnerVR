using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private MenuView _menuView;

    private MenuController _menuController;

    private void Start()
    {
        _menuController = new MenuController(_menuView);
    }
}
