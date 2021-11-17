using UnityEngine;

public class SpawnObstacels 
{
    private GameObject _prefab;
    private Transform[] _obstacels;
    private Rigidbody[] _obstacelsRB;
    private ObstacelsSO _obstacelsSO;
    private float _currentTime;
    private int _currentIndex;

    public SpawnObstacels(GameObject prefab, ObstacelsSO obstacelsSO)
    {
        _prefab = prefab;
        _obstacelsSO = obstacelsSO;
        _currentTime = 0;
        _currentIndex = 0;

        CreateObstacels();
    }

    public void Update()
    {
        _currentTime += Time.deltaTime;

        if(_currentTime > _obstacelsSO.TimeSpawn)
        {
            _currentTime = 0;
            Spawn();
        }
    }

    public Transform[] ReturnObstacleView()
    {
        return _obstacels;
    }

    private void CreateObstacels()
    {
        _obstacels = new Transform[_obstacelsSO.CountObstacels];
        _obstacelsRB = new Rigidbody[_obstacelsSO.CountObstacels];
        var startPosition = new Vector3(-100, -100, 0);

        for (int i = 0; i < _obstacelsSO.CountObstacels; i++)
        {
            _obstacels[i] = Object.Instantiate(_prefab, startPosition, Quaternion.identity).transform;
            _obstacelsRB[i] = _obstacels[i].GetComponent<Rigidbody>();
            
        }
    }

    private void Spawn()
    {
        _obstacels[_currentIndex].gameObject.SetActive(true);

        _obstacels[_currentIndex].transform.position = new Vector3(_obstacelsSO.DistanceSpawnX, _obstacelsSO.DistanceSpawnY, Random.Range(-4, 4));
        _obstacelsRB[_currentIndex].velocity = Vector3.zero;

        _currentIndex++;

        if(_currentIndex == _obstacels.Length)
        {
            _currentIndex = 0;
        }
    }
}
