using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoveUp : MonoBehaviour
{
  public Transform target;


  void Update()
  {
    transform.Rotate(2f * Time.deltaTime, 2f * Time.deltaTime, 2f * Time.deltaTime);
    transform.position = Vector3.MoveTowards(transform.position, target.position, 0.1f * Time.deltaTime);

    
  }


}