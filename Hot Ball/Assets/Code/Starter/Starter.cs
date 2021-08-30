using UnityEngine;

public class Starter : MonoBehaviour
{
    private Score score;

    private void Start()
    {
       score = new Score();
    }

    private void FixedUpdate()
    {
        score.FixedUpdate();
    }
}
