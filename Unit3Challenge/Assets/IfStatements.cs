using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float WeatherTemperature = 85.0f;
    float hotLimitTemperature = 67.0f;
    float coldLimitTemperature = 30.0f;
    

    void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();
        
        WeatherTemperature -= Time.deltaTime * 2f;
    }
    
    
    void TemperatureTest ()
    {
        if(WeatherTemperature > hotLimitTemperature)
        {
            print("It feels too hot today.");
        }
        else if(WeatherTemperature < coldLimitTemperature)
        {
            print("It feels too cold today.");
        }
        else
        {
            print("It feels just right.");
        }
    }
}