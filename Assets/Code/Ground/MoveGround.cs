using UnityEngine;

public class MoveGround 
{
    private Transform _ground;
    private float _speed;

    public MoveGround(Transform ground, float speed)
    {
        _ground = ground;
        _speed = speed;
    }

    public void Update()
    {
        _ground.Translate(_speed * Time.deltaTime * (-1), 0, 0);
    }
}
