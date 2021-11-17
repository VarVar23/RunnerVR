using UnityEngine;

[CreateAssetMenu(fileName = "ObstacelSO", menuName = "Config/ObstacelSO", order = 0)]
public class ObstacelsSO : ScriptableObject
{
    [SerializeField] private int _distanceSpawnX;
    [SerializeField] private int _distanceSpawnY;
    [SerializeField] private int _timeSpawn;
    [SerializeField] private int _countObstacels;

    public int CountObstacels => _countObstacels;
    public int DistanceSpawnX => _distanceSpawnX;
    public int DistanceSpawnY => _distanceSpawnY;
    public int TimeSpawn => _timeSpawn;
}
