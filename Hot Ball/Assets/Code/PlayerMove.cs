using UnityEngine;

namespace Code
{
    public class PlayerMove
    {
        public void Move(Vector3 move, float speed, Rigidbody rigidbody)
        {
            move += new Vector3(Input.GetAxis(InputManager.HORIZONTAL), 0, Input.GetAxis(InputManager.VERTICAL));
            rigidbody.AddForce(move * speed, ForceMode.Force);
        }
    }
}