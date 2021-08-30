using UnityEngine;

namespace Code
{
    public class Player
    {
        private float _speed;
        private float _force;
        private Rigidbody _rigidbody;
        private PlayerMove _playerMove = new PlayerMove();
        private PlayerJump _playerJump = new PlayerJump();
       public void Update(float speed, Rigidbody rigidbody, float force)
        {
            _playerMove.Move(new Vector3(),speed, rigidbody);
            _playerJump.JumpPlayer(new Vector3(),force,rigidbody);
        }
    }
}