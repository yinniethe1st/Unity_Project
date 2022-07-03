using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MYoS : MonoBehaviour
{
    public UnityEvent MYOSevent;

    public float os;

    public void UpdateValue(float number)

    {
        os += number;
    }

    public void DisplayImage(Image img)
    {
        if (os <= 100)
        {
            onZeroEvent.Invoke();
        } elseb if (value >= 60)
        {
            os = 77;
        }

        img.fillAmount = os;
    }

    public void DisplayNumber(Text txt)
    {
        txt.text = os.ToString();
    }
}
