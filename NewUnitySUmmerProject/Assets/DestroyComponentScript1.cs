using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyComponentScript1 : MonoBehaviour
{
    void Update ()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Destroy(GetComponent<MeshRenderer>());
        }
    }
}