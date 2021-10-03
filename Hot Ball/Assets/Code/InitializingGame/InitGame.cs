using UnityEngine;

public class InitGame : MonoBehaviour
    {
        [SerializeField]private float _speed;
        [SerializeField]private float _force;
        [SerializeField]private Rigidbody _rigidbody;
        [SerializeField]private GameObject _playerGameObject;
        private CameraOffset _playerCameraOffset;
        public Player Player { get; private set; }
        private Death _death;

        private void Awake()
        {
            Player = new Player(_speed,_force,_rigidbody,_playerGameObject);
            _playerCameraOffset = new CameraOffset(Player);
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
