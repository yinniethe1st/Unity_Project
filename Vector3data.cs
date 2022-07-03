using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3data : ScriptableObject
{
    
    public UnityEvent VectorEvent;

    public float vector;

    public void UpdateValue(float number)

    {
        vector += number;
    }

    public void DisplayImage(Image img)
    {
        if (vector <= 4)
        {
            onZeroEvent.Invoke();
        } elseb if (value >= 5)
        {
            vector = 5;
        }

        img.fillAmount = vector;
    }

    public void DisplayNumber(Text txt)
    {
        txt.text = vector.ToString();
    }
}
