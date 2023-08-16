using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clases
{
    float c;
    void Start()
    {
        c = MyFunctions.multiplicar(3.6f, 5.9f);
        Debug.Log(c);
    }
}
