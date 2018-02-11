using UnityEngine;
using System.Collections;

public class StartMemory : MonoBehaviour
{

  public GameObject memoryImage;
  private bool approach = false;
  public GameObject pressE;

  void Start()
  {
    pressE.SetActive(false);
  }

  void Update()
  {
    if (approach)
      {
        pressE.SetActive(true);
        if (Input.GetKeyDown(KeyCode.E))
          {
            Debug.Log("enter e");
            memoryImage.SetActive(true);
            StartCoroutine(Delay());
          }
      } else
      {
        pressE.SetActive(false);
      }
  }

  void OnTriggerEnter(Collider coll)
  {
    if (coll.tag == "Player")
      {
        approach = true;
      }

  }

  void OnTriggerExit(Collider coll)
  {
    if (coll.tag == "Player")
      {
        approach = false;
      }
  }

  IEnumerator Delay()
  {
    yield return new WaitForSeconds(3);
    memoryImage.SetActive(false);
  }

}
