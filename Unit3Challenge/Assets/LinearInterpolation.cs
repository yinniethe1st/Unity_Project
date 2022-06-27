using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{
  void Update ()
{
    light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f * Time.deltaTime);
}
}
