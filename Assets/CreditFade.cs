using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CreditFade : MonoBehaviour
{
  public float fadeDuration = 3.0f;
  public bool done = false;
  public GameObject next = null;

  private void Start()
  {
    StartCoroutine(StartFading());
  }

  private void Update()
  {
    if (done)
      {
        next.SetActive(true);
        gameObject.SetActive(false);
      }
  }

  private IEnumerator StartFading()
  {
    yield return StartCoroutine(Fade(0.0f, 1.0f, fadeDuration));
    yield return new WaitForSeconds(5);
    yield return StartCoroutine(Fade(1.0f, 0.0f, fadeDuration));
    yield return new WaitForSeconds(1);
    done = true;
    yield return new WaitForSeconds(1);
  }

  private IEnumerator Fade(float startLevel, float endLevel, float time)
  {
    float speed = 1.0f / time;

    for (float t = 0.0f; t < 1.0; t += Time.deltaTime * speed)
      {
        float a = Mathf.Lerp(startLevel, endLevel, t);
        GetComponent<Text>().color = new Color(GetComponent<Text>().color.r,
          GetComponent<Text>().color.g,
          GetComponent<Text>().color.b, a);
        yield return 0;
      }
  }
}
