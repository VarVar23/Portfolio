
class Score
{
    private ScoreCount _scoreCount;
    
    public Score()
    {
        _scoreCount = new ScoreCount();
    }

    public void FixedUpdate()
    {
        _scoreCount.FixedUpdate();
    }
}

