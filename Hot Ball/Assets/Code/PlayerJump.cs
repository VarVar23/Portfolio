using UnityEngine;

namespace Code
{
    public class PlayerJump
    {
        Vector3 a = Vector3.up;
        public void JumpPlayer(float jumpForce,Rigidbody rigidbody)
        {
            rigidbody.AddForce(a * (Input.GetAxis(InputManager.JUMP) * jumpForce));
        }
    }
}