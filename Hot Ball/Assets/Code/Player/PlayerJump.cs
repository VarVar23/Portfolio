using UnityEngine;

public class PlayerJump
{
    Vector3 move = Vector3.up;

    public void JumpPlayer(float jumpForce, Rigidbody rigidbody)
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            float _input = (Input.GetAxis(InputManager.JUMP));
            rigidbody.AddForce(move * (_input * jumpForce), ForceMode.Impulse);
            Debug.Log("space");
        }
    }
}
