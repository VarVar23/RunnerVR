using UnityEngine;

public class PullGround 
{
    private Transform _ground;
    private float _maxDistantion;
    private Vector3 _startPositionGround;
    
    public PullGround(Transform ground, float maxDistantion)
    {
        _ground = ground;
        _maxDistantion = maxDistantion;
    }

    public void FixedUpdate(Transform lastGround)
    {
        if(_ground.position.x < _maxDistantion)
        {
            _startPositionGround = new Vector3(lastGround.position.x + 10, 0, 0);
            TeleportStartPosition();
        }
    }

    private void TeleportStartPosition()
    {
        _ground.transform.position = _startPositionGround;
    }
}
