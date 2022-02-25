using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUI : MonoBehaviour
{
  private int mainScene = 1;
  private string playerName;

  public void Awake()
  {
    GameObject.FindGameObjectWithTag("Score text").GetComponent<Text>().text = "Best score: " + GameManager.Instance.GetTopScorePlayer() + " " + GameManager.Instance.GetScore();
  }

  public void OnStart()
  {
    GameManager.Instance.SetTopScore(playerName);
    SceneManager.LoadScene(mainScene);
  }

  public void OnQuit()
  {
  #if UNITY_EDITOR
    EditorApplication.ExitPlaymode();
  #else
    Application.Quit();
  #endif
  }

  public void OnNameChange(string change)
  {
    playerName = change;
  }
}