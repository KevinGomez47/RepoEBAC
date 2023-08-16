using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SocialPlatforms;

public class EjerciciosEstructuras : MonoBehaviour
{
    void Start()
    {
        
        //Este es solo un separador para la consola
        Debug.Log("=====Separador Funcion Generadora de listas=====");


        //Se prueba si la lista funciona y se recorre la lista con un foreach
        ListCreator(5, -50, 50, out List<int> myNewIntList);
        foreach (int i in myNewIntList) Debug.Log(i);

        //Este es solo un separador para la consola
        Debug.Log("=====Separador Funcion Organizadora=====");


        //Se prueba si el organizador de lista funciona, usaldo la lista creada por la funcion anterior
        listOrganizer(myNewIntList, out List<int> newOrganizedList);
        foreach (int i in newOrganizedList) Debug.Log(i);


        //Este es solo un separador para la consola
        Debug.Log("=====Separador Función Sin Datos Repetidos=====");
        

        //Se usa el método listCreator para crear una lista con valores repeidos
        ListCreator(20, 0, 5, out List<string> myNewStringList);
        listCleaner(myNewStringList, out HashSet<string> myNewCleanHashSet);
        foreach(string s in myNewCleanHashSet) Debug.Log(s);


        //Este es solo un separador para la consola
        Debug.Log("=====Separador Funcion De Pila & Cola=====");


        ListCreator(11, out Stack<string> myStack);
        destackerEnqueuer(myStack);


    }


    //Esta funcion devuelve una lista de enteros de n longitud dada por length
    void ListCreator(int length, int topRange, int lowRange, out List<int> newList)
    {
        var list = new List<int>();
        for(int i = 0; i < length; i++) list.Add(Random.Range(topRange, lowRange));
        newList = list;
    }


    //Esta funcion devuelve una lista de cadenas de n longitud dada por length (Sobrecarga del método ListCreator)
    void ListCreator(int length, int topRange, int lowRange, out List<string> newList)
    {
        var list = new List<string>();
        for (int i = 0; i < length; i++) list.Add($"El número {Random.Range(topRange, lowRange)} no se debe repetir");
        newList = list;
    }

    //Esta funcion devuelve una pila de cadenas de n longitud dada por length (Sobrecarga del método ListCreator)
    void ListCreator(int length, out Stack<string> newStack)
    {
        var stack = new Stack<string>();
        for (int i = 0; i < length; i++)
        {
            if (i < 10) stack.Push($"Usuario 00{i}");
            else if (i >= 10 && i < 100) stack.Push($"Usuario 0{i}");
            else stack.Push($"Usuario {i}");
        }
        newStack = stack;
    }


    //Esta funcion devuelve una lista de enteros dada por list organizada de manera descentente
    void listOrganizer(List<int> list, out List<int> organizedList)
    {
        organizedList = list.OrderByDescending(n => n).ToList();
    }


    //Esta funcion devuelve un HashSet de cadenas no repetidas dado por list
    void listCleaner(List<string> list, out HashSet<string> shiningList)
    {
        shiningList = list.Distinct().ToHashSet();
    }

    // Esta funcion se encarga de imprimir los datos de una pila y relenar con ellos una cola, para despues imprimir sus elementos
    // Nota: Use un bucle for porque el inciso pedía usar los métodos Enqueue, Dequeue, Push y Pop.
    void destackerEnqueuer(Stack<string> users)
    {
        Queue<string> newQueue = new Queue<string>();
        for (int i = users.Count; i > 0; i--)
        {
            string user = users.Peek();
            Debug.Log("Stack: " + user);
            newQueue.Enqueue(user);
            users.Pop();
        }
        for (int i = newQueue.Count; i > 0; i--)
        {
            Debug.Log("Queue: " + newQueue.Peek());
            newQueue.Dequeue();
        }
    }

}
