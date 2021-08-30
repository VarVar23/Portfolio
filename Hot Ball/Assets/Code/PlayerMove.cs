using UnityEngine;

namespace Code
{
    public class PlayerMove
    {
        private float _speed;
        private Vector3 _move;
        private Rigidbody _rigidbody;

        public float Speed { get => _speed; set => _speed = value; }

        public Vector3 MovePlayer { get => _move; set => _move = value; }

        public Rigidbody Rigidbody { get => _rigidbody; set => _rigidbody = value; }

        public PlayerMove(float speed, Vector3 vector3, Rigidbody rigidbody)
        {
            Speed = speed;
            MovePlayer = vector3;
            Rigidbody = rigidbody;
        }
        public void Move(Vector3 move, float speed, Rigidbody rigidbody)
        {
            move += new Vector3(Input.GetAxis(CONSTANT_NAME.Left), 0, Input.GetAxis(CONSTANT_NAME.Rigth));
            rigidbody.AddForce(move * speed, ForceMode.Force);
        }
    }
}