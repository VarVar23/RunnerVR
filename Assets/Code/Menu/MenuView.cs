using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MenuView : MonoBehaviour
{
    [SerializeField] private Button _startButton;
    [SerializeField] private Button _exitButton;

    public void InitStart(UnityAction delegateButtonStart)
    {
        _startButton.onClick.AddListener(delegateButtonStart);
    }

    public void InitExit(UnityAction delegateButtonExit)
    {
        _exitButton.onClick.AddListener(delegateButtonExit);
    }
}
