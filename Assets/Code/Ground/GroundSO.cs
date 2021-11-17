using UnityEngine;

[CreateAssetMenu(fileName = "GroundSO", menuName = "Config/GroundSO", order = 0)] 
public class GroundSO : ScriptableObject
{
    [SerializeField] private float _speed;
    [SerializeField] private float _maxDistantion;
    public float Speed => _speed;
    public float MaxDistantion => _maxDistantion;
}
