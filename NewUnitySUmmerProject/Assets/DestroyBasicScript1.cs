using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBasicScript1 : MonoBehaviour
{
    void Update ()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }
}