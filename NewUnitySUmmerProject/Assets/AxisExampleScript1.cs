using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisExampleScript1 : MonoBehaviour
{
    public float range;
    public Text textOutput;
    
    
    void Update () 
    {
        float h = Input.GetAxis("Horizontal");
        float xPos = h * range;
        
        transform.position = new Vector3(xPos, 2f, 0);
        textOutput.text = "Value Returned: " + h.ToString("F2");  
    }
}
