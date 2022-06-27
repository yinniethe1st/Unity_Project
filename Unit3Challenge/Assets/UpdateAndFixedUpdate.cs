using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    void FixedUpdate ()
    {
        Debug.Log("FixedUpdate error in Time :" + Time.deltaTime);
    }
    
    
    void Update ()
    {
        Debug.Log("Update  error in Time :" + Time.deltaTime);
    }
}