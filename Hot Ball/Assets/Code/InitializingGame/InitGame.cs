using UnityEngine;

public class InitGame : MonoBehaviour
    {
        [Header("Игрок")]
        [SerializeField]private float _speed;
        [SerializeField]private float _force;
        [SerializeField]private Rigidbody _rigidbody;
        [SerializeField]private GameObject _playerGameObject;
        [Header("Объект камеры")]
        [SerializeField]private GameObject _offsetCameraGameObject;
        [Header("Расстояние камеры от игрока")]
        [SerializeField]private Vector3 _offsetCamera;
        private CameraOffset _playerCameraOffset;
        public Player Player { get; private set; }
        private Death _death;

        private void Awake()
        {
            Player = new Player(_speed,_force,_rigidbody,_playerGameObject);
            _playerCameraOffset = new CameraOffset(Player,_offsetCamera,_offsetCameraGameObject);
            _death = new Death();
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
