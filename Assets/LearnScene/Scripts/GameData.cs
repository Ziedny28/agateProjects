
public class GameData
{
    public static GameData Data = new GameData();
    public int CurrentScore = 0;
    public int HighScore = 0;

    public void AddScore(int score)
    {
        CurrentScore += score;
        if (CurrentScore > HighScore)
        {
            HighScore = CurrentScore;
        }
    }
    public void ResetScore()
    {
        CurrentScore = 0;
    }
}