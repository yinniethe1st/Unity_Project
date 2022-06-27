using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour
{
    public int alpha = 10;
    
    
    private int beta = 5;
    private int gamma = 10;
    
    
    private AnotherClass myOtherClass;
    
    
    void Start ()
    {
        alpha = 20;
        
        myOtherClass = new AnotherClass();
        myOtherClass.CarShows (alpha, myOtherClass.mercedes);
    }
    
    
    void Example (int mercedes, int bmw)
    {
        int carModel;
        carModel = mercedes * bmw * alpha;
        Debug.Log(carModel);
    }
    
    
    void Update ()
    {
        Debug.Log("Car model is: " + alpha);
    }
}