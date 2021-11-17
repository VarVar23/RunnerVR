using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeathController 
{
    private Rigidbody _playerRigidbody;
    private GameObject _panelDeath;
    private int _hp;

    public PlayerDeathController(ObstacelsView[] obstacelsView, Rigidbody playerRigidbody, GameObject panelDeath, int hp)
    {
        _playerRigidbody = playerRigidbody;
        _panelDeath = panelDeath;
        _hp = hp;

        for (int i = 0; i < obstacelsView.Length; i++)
        {
            obstacelsView[i].ObstacelTouchPlayer += Damage;
        }
    }

    public void Update()
    {
        if(_playerRigidbody.velocity.y < -10 || _hp < 0)
        {
            Death();
        }
    }

    private void Damage() =>
        _hp--;


    private void Death() =>
        SceneManager.LoadScene(0);

}
