using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chars : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        var myChar = new[]
        {
            'j',
            '\u006A',
            '\x006A',
            (char)106
        };
        foreach (char c in myChar)
        {
            Debug.Log(c);
        }
        */

        string myText = $"Hola tú";
        double myDouble = char.GetNumericValue(myText, 5);
        Debug.Log(myDouble);

        //char one = '9';
        //char two = '5';

        char myChar = '9';
        int myInt;
        if (int.TryParse(myChar.ToString(), out myInt)) Debug.Log("El número es : \v" + myInt);
        else Debug.Log("El dato no es un número");

        Debug.Log(myText.Substring(0, 3));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
