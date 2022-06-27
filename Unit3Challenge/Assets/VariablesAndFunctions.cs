using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    int myInt = 10;
     void Start ()
     {
        myInt = MultiplybyThree(myInt);
        Debug.Log (myInt);
     }

     int MultiplybyThree (int number)
     {
        int result;
        result = number * 3;
        return result;
     }
}
