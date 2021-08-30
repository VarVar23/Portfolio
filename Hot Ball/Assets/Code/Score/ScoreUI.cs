using TMPro;

public class ScoreUI 
{
    private TextMeshProUGUI _text;
    private ScoreCount _scoreCountClass;

    public ScoreUI(TextMeshProUGUI text, ScoreCount scoreCount)
    {
        _text = text;
        _scoreCountClass = scoreCount;
    }

    public void FixedUpdate() =>
        _text.text = Constants.SCORE + _scoreCountClass.ScoreGame;

}
