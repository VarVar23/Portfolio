using System;
using UnityEngine;

namespace Code
{
    public class InitGame : MonoBehaviour
    {
        [SerializeField]private float _speed;
        [SerializeField]private Vector3 _move;
        [SerializeField]private Rigidbody _rigidbody;
        private PlayerMove _playerMove;

        private void Awake()
        {
            _playerMove = new PlayerMove(_speed,_move,_rigidbody);
        }

        private void Update()
        {
            _playerMove.Move(_playerMove.MovePlayer,_playerMove.Speed, _playerMove.Rigidbody);
        }
    }
}