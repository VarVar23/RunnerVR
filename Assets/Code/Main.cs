using UnityEngine;

public class Main : MonoBehaviour
{
    [Header("Scriptable Object")]
    [SerializeField] private GroundSO _groundSO;
    [SerializeField] private ObstacelsSO _obstacelsSO;
    [SerializeField] private PlayerSO _playerSO;

    [Header("View")]
    [SerializeField] private GroundView[] _groundsView;
    [SerializeField] private PlayerView _playerView;
    private ObstacelsView[] _obstacelsView;

    [Space(15)]
    [SerializeField] private GameObject _prefabObstacle;
    [SerializeField] private GameObject _vrCamera;
    [SerializeField] private GameObject _panelDeath;

    private GroundController _groundController;
    private SpawnObstacels _spawnObstacels;
    private PlayerAnimationController _playerAnimationController;
    private PlayerMoveController _playerController;
    private PlayerDeathController _playerDeathController;

    private void Start()
    {
        Initialize();
    }

    private void Update()
    {
        _groundController.Update();
        _spawnObstacels.Update();
        _playerController.Update();
        _playerDeathController.Update();
    }

    private void FixedUpdate()
    {
        _groundController.FixedUpdate();
    }

    private void Initialize()
    {
        _groundController = new GroundController(_groundsView, _groundSO);
        _spawnObstacels = new SpawnObstacels(_prefabObstacle, _obstacelsSO);

        _obstacelsView = FindObjectsOfType<ObstacelsView>();
        _playerAnimationController = new PlayerAnimationController(_obstacelsView, _playerView.PlayerAnimator);
        _playerController = new PlayerMoveController(_vrCamera, _playerSO, _playerView.PlayerRigidbody);
        _playerDeathController = new PlayerDeathController(_obstacelsView, _playerView.PlayerRigidbody, _panelDeath, _playerSO.Hp);
    }
}
