using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableComponents : MonoBehaviour
{
    private Apple myApple;
    
    
    void Start ()
    {
        myApple = GetComponent<Apple>();
    }
    
    
    void Update ()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            myApple.enabled = !myApple.enabled;
        }
    }
}
