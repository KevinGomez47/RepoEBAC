using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolVars : MonoBehaviour
{
    /*
    bool myTrue = true;
    bool myFalse = false;
    bool myBool;
    int myValue;
    int highest = 6;
    int lowest = -5;
    enum myColor
    {
        Red,
        Green,
        Blue,
        Yellow,
        Oragnge
    }
    */

    int myRand;
    int highest = 100;
    int lowest = -100;


    // Start is called before the first frame update
    void Start()
    {
        myRand = Random.Range(highest, lowest);
        Debug.Log(((myRand % 2) == 0) ? myRand + " is even": myRand + " is odd");

        /*
        if (myBool && myTrue)
        {
            Debug.Log("Hola mundo");
        };

        if (!myTrue)
        {
            Debug.Log("Hola mundo");
        } else
        {
            Debug.Log("Adios mundo");
        };

        if ((myTrue || myFalse) && myBool)
        {
            Debug.Log("Hola mundo");
        } else if (myBool && myFalse)
        {
            Debug.Log("Adios mundo");
        } else
        {
            Debug.Log("Este mundo");
        }

        if (myBool) Debug.Log("Hola mundo");
        else if (myTrue) Debug.Log("Adios mundo");

        if (1 < 2) Debug.Log("Uno es menor que dos");

        if ('1' != 1) Debug.Log("Estos datos no son iguales");

        switch (myValue)
        {
            case (int)myColor.Red:
                Debug.Log("El color es rojo");
                break;
            case (int)myColor.Green:
                Debug.Log("El color es verde");
                break;
            case (int)myColor.Blue:
                Debug.Log("El color es azul");
                break;
            case (int)myColor.Yellow:
                Debug.Log("El color es amarillo");
                break;
            case (int)myColor.Oragnge:
                Debug.Log("El color es naranja");
                break;
            default:
                Debug.Log("El color no existe");
                break;
        };
        myValue = Random.Range(highest, lowest);
        Debug.Log(myValue >= 0 ? "El valor es positivo" : "El valor es negativo");
        */


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
