using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    // ���������� ����� � PlayerPrefs
    public void SaveScore(string ScoreKey, int score)
    {
        PlayerPrefs.SetInt(ScoreKey, score);
        PlayerPrefs.Save();
    }

    // �������� ����������� ����� �� PlayerPrefs
    public int LoadScore(string ScoreKey)
    {
        if (PlayerPrefs.HasKey(ScoreKey))
        {
            return PlayerPrefs.GetInt(ScoreKey);
        }
        else
        {
            return 0;
        }
    }

    // ������� ����������� �����
    public void ResetScore(string ScoreKey)
    {
        PlayerPrefs.DeleteKey(ScoreKey);
    }
}