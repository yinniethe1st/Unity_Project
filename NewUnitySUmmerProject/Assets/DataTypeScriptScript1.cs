using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypeScriptScript1 : MonoBehaviour
{
    void Start () 
    {
        //Value type variable
        Vector3 pos = transform.position;
        pos = new Vector3(0, 2, 0);
        
        //Reference type variable
        Transform tran = transform;
        tran.position = new Vector3(0, 2, 0);
    }
}