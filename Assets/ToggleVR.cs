using UnityEngine;
using UnityEngine.VR;

public class ToggleVR : MonoBehaviour
{
  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.V))
      {
        VRSettings.enabled = !VRSettings.enabled;
        Debug.Log("Changed VRSettings.enabled to: " + VRSettings.enabled);
      }
  }
}