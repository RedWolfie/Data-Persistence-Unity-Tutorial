using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public static GameManager Instance;

  public int score;
  public string playerName;

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

  public void SetTopScore()
  {
    if (score > topScore)
    {
      topScore = score;
      topScorePlayer = playerName;
      SaveData();
    }
    score = 0;
  }
  
  [Serializable]
  class ScoreData
  {
    public int score;
    public string name;
  }

  public void SaveData()
  {
    ScoreData data = new ScoreData()
    {
      score = topScore,
      name = topScorePlayer
    };
    File.WriteAllText(Application.persistentDataPath + "/savefile.json", JsonUtility.ToJson(data));    
  }

  public void LoadData()
  {
    string path = Application.persistentDataPath + "/savefile.json";
    if(File.Exists(path))
    {
      ScoreData data = JsonUtility.FromJson<ScoreData>(File.ReadAllText(path));
      topScore = data.score;
      topScorePlayer = data.name;
    }
  }
}
