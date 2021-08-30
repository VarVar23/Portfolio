using UnityEngine;

public class ScoreCount
{
    private int _score;
    public float ScoreGame { get => _score; }

    public void FixedUpdate() =>
        _score = (int)(Time.time * Constants.NiceScoreCount);

}
