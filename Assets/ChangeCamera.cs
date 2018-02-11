using UnityEngine;
using System.Collections;

public class ChangeCamera : MonoBehaviour
{

  public GameObject firstCamera;
  public GameObject secondCamera;
  private bool approach = false;

  void Update()
  {
    if (approach)
      {
        secondCamera.SetActive(true);
        firstCamera.SetActive(false);
      }
  }

  void OnTriggerEnter(Collider coll)
  {
    if (coll.tag == "Player")
      {
        approach = true;
      }
  }
}
