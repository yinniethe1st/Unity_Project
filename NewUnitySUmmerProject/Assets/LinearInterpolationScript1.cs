using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolationScript1 : MonoBehaviour
{
    // Start is called before the first frame update
 void Update ()
{
    GetComponent<Light>().intensity = Mathf.Lerp(GetComponent<Light>().intensity, 8f, 0.5f);
}
}
