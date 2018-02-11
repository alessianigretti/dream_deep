using UnityEngine;
using System.Collections;

public class SlowSpeed : MonoBehaviour
{

  public GameObject smoke;
  public GameObject smokeRight;
  public GameObject smokeLeft;

  void Start()
  {
    smoke.GetComponent<ParticleSystem>().playbackSpeed = 0.1f;
    smokeRight.GetComponent<ParticleSystem>().playbackSpeed = 0.1f;
    smokeLeft.GetComponent<ParticleSystem>().playbackSpeed = 0.1f;
  }
}
