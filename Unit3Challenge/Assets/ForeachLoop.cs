using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoop : MonoBehaviour
{   
    void Start () 
    {
        string[] strings = new string[3];
        
        strings[0] = "First item";
        strings[1] = "Second item";
        strings[2] = "Third item";
        
        foreach(string item in strings)
        {
            print (item);
        }
    }
}