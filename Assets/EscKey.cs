using UnityEngine;
using System.Collections;

public class EscKey : MonoBehaviour
{

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Escape))
      {
        Debug.Log("Escape");
        Application.Quit();
      }
  }
}
