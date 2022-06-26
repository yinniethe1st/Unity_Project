using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAtScript1 : MonoBehaviour
{
    public Transform target;
    
    void Update ()
    {
        transform.LookAt(target);
    }
}