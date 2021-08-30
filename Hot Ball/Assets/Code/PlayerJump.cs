using UnityEngine;

namespace Code
{
    public class PlayerJump
    {
        public void JumpPlayer(Vector3 move, float jump, Rigidbody rigidbody)
        {
            move += new Vector3(0, Input.GetAxis(InputManager.JUMP), 0);
            rigidbody.AddForce(move,ForceMode.Impulse);
        }
    }
}