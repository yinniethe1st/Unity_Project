using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhileLoop : MonoBehaviour 
{
    void Start()
    {
        bool saySomething = false;
        
        do
        {
            print ("Hello, Welcome to Utah");
            
        }while(saySomething == true);
    }
}