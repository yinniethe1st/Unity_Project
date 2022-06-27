using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    int CupcakesOnTheTable = 10;
    
    
    void Start ()
    {
        while(CupcakesOnTheTable > 0)
        {
            Debug.Log ("I've eaten more than 1 cupcake!");
            CupcakesOnTheTable--;
        }
    }
}