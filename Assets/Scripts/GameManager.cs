using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public static GameManager Instance;
  public int score;
  private int topScore;
  private string topScorePlayer;
  private void Awake()
  {
    if (Instance != null)
    {
      Destroy(gameObject);
      return;
    }
    Instance = this;
    DontDestroyOnLoad(gameObject);
  }

  public int GetScore()
  {
    return topScore;
  }

  public string GetTopScorePlayer()
  {
    return topScorePlayer;
  }

  public void SetTopScore(string name)
  {
    if (score > topScore)
    {
      topScore = score;
      topScorePlayer = name;
    }
    score = 0;
  }
}
