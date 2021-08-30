using UnityEngine;
namespace Code
{
    public class PlayerMove : MonoBehaviour
    {
        [SerializeField]private float _speedPlayer;
        [SerializeField]private Transform _transformPlayer;
        private float _deltaTimeSpeed;
        private Vector3 _movePlayer;
        private PlayerJump _jumpPlayer;
        private PlayerMove _playerMove;

        public PlayerMove(Transform transform, float speed)
        {
            _speedPlayer = speed;
            _transformPlayer = transform;
        }
        private void Awake()
        {
            _playerMove = new PlayerMove(_transformPlayer, _speedPlayer);
        }

        private void Update()
        {
            _playerMove._movePlayer.Set(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            _deltaTimeSpeed = Time.deltaTime * _speedPlayer;
            _playerMove._transformPlayer.Translate(  _playerMove._movePlayer * _deltaTimeSpeed, Space.World);
            transform.localPosition += _movePlayer;
        }
    }
}