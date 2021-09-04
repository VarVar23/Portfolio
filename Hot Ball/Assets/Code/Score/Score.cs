using TMPro;
class Score
{
    private ScoreUI _scoreUI;
    private ScoreCount _scoreCount;
    private ScoreSave _scoreSave;

    public Score(TextMeshProUGUI text)
    {
        _scoreCount = new ScoreCount();
        _scoreUI = new ScoreUI(text, _scoreCount);
        _scoreSave = new ScoreSave();
    }

    public void FixedUpdate()
    {
        _scoreCount.FixedUpdate();
        _scoreUI.FixedUpdate();
    }

    public void Save()
    {
        _scoreSave.SaveBestScore(_scoreCount.ScoreGame);
    }
        
    public int Load()
    {
        return _scoreSave.LoadBestScore();
    }
}

