using UnityEngine;

public class InitGame : MonoBehaviour
{
    [Header("Игрок")] [SerializeField] private float _speed;
    [SerializeField] private float _force;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private GameObject _playerGameObject;

    [Header("Объект камеры")] [SerializeField]
    private GameObject _offsetCameraGameObject;

    [Header("Расстояние камеры от игрока")] [SerializeField]
    private Vector3 _offsetCamera;

    private CameraOffset _playerCameraOffset;
    private Death _death;
    private Colls _colls;
    public GameObject _playerColls;
    public Player Player { get; private set; }
    public Death Death => _death;

    private void Awake()
    {
        Player = new Player(_speed, _force, _rigidbody, _playerGameObject);
        _death = new Death();
        _playerCameraOffset = new CameraOffset(Player, _offsetCamera, _offsetCameraGameObject);
        _colls = new Colls(_playerColls);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            _colls.CollisionPlayer(gameObject);
        }
    }

    private void Update()
    {
        Player.Update(Player);
        _playerCameraOffset.FollowPlayer();
    }

    private void FixedUpdate()
    {
        Player.FixedUpdate(Player);
    }
}
