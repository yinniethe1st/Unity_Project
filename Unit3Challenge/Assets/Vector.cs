using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector : MonoBehaviour
{
    public Transform other;

    void Update()
    {
        if (other)
        {
            Vector1 forward = transform.TransformDirection(Vector1.forward);
            Vector1 toOther = other.position - transform.position;

            if (Vector1.Dot(forward, toOther) < 0)
            {
                print("The other transform is above me!");
            }
        }
    }
}
