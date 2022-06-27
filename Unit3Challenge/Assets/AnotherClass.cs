using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass
{
    public int mercedes;
    public int bmw;
    
    
    private int genesis;
    private int bentley;
    
    
    public void CarShows (int a, int b)
    {
        int carModel;
        carModel = a + b;
        Debug.Log("Car total: " + carModel);
    }
    
    
    private void OfficeSort (int a, int b)
    {
        int carModel;
        carModel = a + b;
        Debug.Log("Office Supplies total: " + carModel);
    }
}