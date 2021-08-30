using System;
using UnityEngine;

namespace Code
{
    public class PlayerJump : PlayerMove
    {
        [SerializeField] private float _jumpForce;
        private Vector3 _jumpMove;
        private float _speedPlayer;
        private Transform _transformPlayer;
        public PlayerJump(Transform transform, float speed, float jumpForce) : base(transform, speed)
        {
            _jumpForce = jumpForce;
        }

        private void OnCollisionStay(Collision other)
        {
            if (gameObject.CompareTag("Player") && transform.position.y < 5)
            {
                _jumpMove.Set(0, Input.GetAxis("Jump"), 0);
                transform.Translate(0,_jumpMove.y*_jumpForce,0);
                transform.localPosition += _jumpMove;
            }
        }
    }
}