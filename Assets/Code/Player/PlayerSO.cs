using UnityEngine;


[CreateAssetMenu(fileName = "PlayerSO", menuName = "Config/PlayerSO", order = 0)]
public class PlayerSO : ScriptableObject
{
    [SerializeField] private float _sideSpeed;
    [SerializeField] private float _deathZoneCamera;
    [SerializeField] private int _hp;
    public float SideSpeed => _sideSpeed;
    public float DeathZoneCamera => _deathZoneCamera;
    public int Hp => _hp;
}
