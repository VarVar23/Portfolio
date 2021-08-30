using TMPro;
class Score
{
    private ScoreUI _scoreUI;
    private ScoreCount _scoreCount;

    public Score(TextMeshProUGUI text)
    {
        _scoreCount = new ScoreCount();
        _scoreUI = new ScoreUI(text, _scoreCount);
    }

    public void FixedUpdate()
    {
        _scoreCount.FixedUpdate();
        _scoreUI.FixedUpdate();
    }
}

