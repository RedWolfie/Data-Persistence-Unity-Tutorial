using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUI : MonoBehaviour
{
  public void onStart ()
  {
    Debug.Log("Started");
  }

  public void onQuit ()
  {
    Debug.Log("Quit");
  }

  public void onNameChange()
  {
    Debug.Log("Name Change");
  }
}
