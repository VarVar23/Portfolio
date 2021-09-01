using UnityEngine;

namespace Code
{
    public class PlayerMove
    {
        private Vector3 _move;
        public void Move(float speed, Rigidbody rigidbody)
        {
            _move += new Vector3(Input.GetAxis(InputManager.HORIZONTAL), 0, Input.GetAxis(InputManager.VERTICAL) * speed);
            _move = Vector3.ClampMagnitude(_move, speed);
            _move.y = rigidbody.velocity.y;
            rigidbody.velocity = _move;

        }
    }
}