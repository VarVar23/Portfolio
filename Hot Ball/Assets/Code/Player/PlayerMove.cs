using UnityEngine;

public class PlayerMove
    {
        private Vector3 _move;
        public void Move(float speed, Rigidbody rigidbody)
        {
            _move += new Vector3(Input.GetAxis(InputManager.HORIZONTAL), 0, (Vector3.forward.z * speed *Time.deltaTime)); 
            // <- едет только в сторону, но не прямо и в сторону
            _move = Vector3.ClampMagnitude(_move, speed);
            _move.y = rigidbody.velocity.y;
            rigidbody.velocity = _move;

        }
    }
