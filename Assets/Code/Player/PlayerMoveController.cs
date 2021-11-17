using UnityEngine;

public class PlayerMoveController 
{
    private Rigidbody _playerRigidbody;
    private GameObject _vrCamera;
    private float _sideSpeed;
    private float _deathZoneCamera;
    private float _dirX;

    public PlayerMoveController(GameObject vrCamera, PlayerSO playerSO, Rigidbody playerRigidbody)
    {
        _vrCamera = vrCamera;
        _sideSpeed = playerSO.SideSpeed;
        _deathZoneCamera = playerSO.DeathZoneCamera;

        _playerRigidbody = playerRigidbody;
    }

    public void Update()
    {
        Move();
        CheckDeath();
    }

    private void Move()
    {
        if(_vrCamera.transform.rotation.eulerAngles.z > _deathZoneCamera && _vrCamera.transform.rotation.eulerAngles.z <= 180)
        {
            _dirX = -1 * _vrCamera.transform.rotation.eulerAngles.z;
        }
        else if(_vrCamera.transform.rotation.eulerAngles.z > 180 && _vrCamera.transform.rotation.eulerAngles.z <= 360 - _deathZoneCamera)
        {
            _dirX = 360 - _vrCamera.transform.rotation.eulerAngles.z;
        }

        _dirX *= Time.deltaTime * _sideSpeed;
        var velocity = _playerRigidbody.velocity;

        _playerRigidbody.velocity = new Vector3(velocity.y, velocity.y, -_dirX);
    }

    private void CheckDeath()
    {
        if(_playerRigidbody.velocity.y < -5)
        {
            Death();
        }
    }

    private void Death()
    {

    }
}
