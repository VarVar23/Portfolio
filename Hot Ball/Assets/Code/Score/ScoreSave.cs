using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class ScoreSave
{
    private BinaryFormatter _formatter;

    public ScoreSave() =>
        _formatter = new BinaryFormatter();

    public void SaveBestScore(int bestScore)
    {
        using(FileStream stream = new FileStream(Constants.PathSaveBestScore, FileMode.OpenOrCreate))
        {
            _formatter.Serialize(stream, bestScore);
        }
    }

    public int LoadBestScore()
    {
        using (FileStream stream = new FileStream(Constants.PathSaveBestScore, FileMode.Open))
        {
            return (int)_formatter.Deserialize(stream);
        }
    }
}
