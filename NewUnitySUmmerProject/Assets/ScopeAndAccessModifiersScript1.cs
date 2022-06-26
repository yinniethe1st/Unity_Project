using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifiersScript1 : MonoBehaviour
{
    public int alpha = 5;
    
    
    private int beta = 0;
    private int gamma = 5;
    
    
    private AnotherClassScript1 myOtherClass;
    
    
    void Start ()
    {
        alpha = 29;
        
        myOtherClass = new AnotherClassScript1();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }
    
    
    void Example (int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }
    
    
    void Update ()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}