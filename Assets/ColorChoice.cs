using UnityEngine;
using System.Collections;

public class ColorChoice : MonoBehaviour
{
  private bool approach = false;
  public GameObject popUp;

  public GameObject anygameobj;

  void Start()
  {
    popUp.SetActive(false);
  }

  void Update()
  {
    if (approach)
      {
        popUp.SetActive(true);
        GameObject[] array = GameObject.FindGameObjectsWithTag("Floor");

        if (Input.GetKeyDown(KeyCode.R))
          {
            for (int i = 0; i < array.Length; i++)
              {
                array[i].GetComponent<Renderer>().material.color = new Color(10, 1, 1, 10);
              }
          }
        if (Input.GetKeyDown(KeyCode.G))
          {
            for (int i = 0; i < array.Length; i++)
              {
                array[i].GetComponent<Renderer>().material.color = new Color(1, 10, 1, 10);
              }
          }
        if (Input.GetKeyDown(KeyCode.B))
          {
            for (int i = 0; i < array.Length; i++)
              {
                array[i].GetComponent<Renderer>().material.color = new Color(1, 1, 10, 10);
              }
          }
      } else
      {
        popUp.SetActive(false);
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
}
