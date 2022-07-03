using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject

{
    public UnityEvent onZeroEvent;

    public float value;

    public void UpdateValue(float number)

    {
        value += number;
    }

    public void DisplayImage(Image img)
    {
        if (value <= 0)
        {
            onZeroEvent.Invoke();
        } elseb if (value >= 1)
        {
            value = 1;
        }

        img.fillAmount = value;
    }

    public void DisplayNumber(Text txt)
    {
        txt.text = value.ToString();
    }
   
}
