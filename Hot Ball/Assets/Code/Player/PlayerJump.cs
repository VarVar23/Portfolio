using UnityEngine;

namespace Code
{
    public class PlayerJump
    {
        Vector3 move = Vector3.up;
        public void JumpPlayer(float jumpForce,Rigidbody rigidbody)
        {
            float _input = (Input.GetAxis(InputManager.JUMP));
            
            rigidbody.AddForce(move * (_input* jumpForce) , ForceMode.Impulse);
        }
    }
}