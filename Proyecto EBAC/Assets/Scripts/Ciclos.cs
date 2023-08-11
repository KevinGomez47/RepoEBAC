using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciclos : MonoBehaviour
{
    // Start is called before the first frame update
    string[] myWeek = new string[7]
    {
        "Lunes",
        "Marter",
        "Miercoles",
        "Jueves",
        "Viernes",
        "Sabado",
        "Domindo"
    };
    int[,,] myArray = new int[4, 2, 5]
    {
        {
            {9, 0, 7, 6, 0},
            {8, 5, 3, 9, 2}
        },
        {
            {8, 6, 4, 0, 1},
            {3, 7, 1, 5, 0}
        },
        {
            {7, 4, 1, 2, 0},
            {9, 6, 0, 2, 5}
        },
        {
            {5, 8, 0, 3, 1},
            {1, 6, 2, 4, 1}
        }
    };

    int[][] myJagged = new int[2][];

    void Start()
    {
        myJagged[0] = new int[4] {0, 7, 5, 4};
        myJagged[1] = new int[] {0, 3, 5};


        myJagged[0] = new int[] {4, 5, 1 };

        Debug.Log(myJagged[0][3 ]);
 
        /*
        for (int i = 0; i < myWeek.Length; i++)
        {
            Debug.Log(myWeek[i]);
        }
        for (int a = 0; a < myArray.GetLength(0); a++)
        {
            for (int b = 0; b < myArray.GetLength(1); b++)
            {
                for(int c = 0; c < myArray.GetLength(2); c++)
                {
                    Debug.Log($"Fila: {a}, Sub-fila: {b}, Fila: {c} Resultado: {myArray[a, b, c]}");
                }
            }
        }
        */


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
