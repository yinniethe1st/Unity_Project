using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolationScript2 : MonoBehaviour
{void Update ()
{
    GetComponent<Light>().intensity = Mathf.Lerp(GetComponent<Light>().intensity, 8f, 0.5f * Time.deltaTime);
}
}
