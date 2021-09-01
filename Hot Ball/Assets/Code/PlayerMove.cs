using UnityEngine;

namespace Code
{
    public class PlayerMove
    {
        private Vector3 _move;
        public void Move(float speed, Rigidbody rigidbody)
        {
            _move += new Vector3(Input.GetAxis(InputManager.HORIZONTAL), 0, Input.GetAxis(InputManager.VERTICAL));
            rigidbody.velocity = _move * speed;
        }
    }
}