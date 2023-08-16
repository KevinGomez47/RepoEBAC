using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EstructurasDeDatos : MonoBehaviour
{
    List<int> numList = new List<int>();
    List<int> myList = new List<int>();
    HashSet<int> hashSetInt = new HashSet<int>();
    Queue<string> queueString = new Queue<string>();
    Stack<string> stackString = new Stack<string>();
    Dictionary<string, float> myDictionaty = new Dictionary<string, float>();
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 50; i++)
        {
            myList.Add(Random.Range(-50,50));
        }
        var orderList = myList.Where(n => n > 0).OrderBy(n => n).ToList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void domeList()
    {
        for (int i = 0; i < 20; i++)
        {
            numList.Add(Random.Range(0, 100));
        }
        int toRemove = numList[10];
        Debug.Log(toRemove + "\n");
        numList.Sort();
        numList.Remove(toRemove);
        numList.RemoveAt(10);
        foreach (int i in numList)
        {
            Debug.Log(i);
        }
    }

    void demoHashSet()
    {
        for (int i = 0; i < 20; i++)
        {
            hashSetInt.Add(i);
        }
        if (hashSetInt.Contains(5)) hashSetInt.Remove(5);
        else Debug.Log("El HashSet no contiene el elemento");
    }

    void demoQueue()
    {
        for (int i = 0; i < 5; i++)
        {
            queueString.Enqueue($"Proyectil {i}");
        }
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(queueString.Peek());
            queueString.Dequeue();
        }
    }

    void demoStack()
    {
        for (int i = 0; i < 5; i++)
        {
            stackString.Push($"Carta {i}");
        }
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(stackString.Peek());
            stackString.Pop();
        }
    }

    void demoDictionaty(string arma)
    {
        for (int i = 0; i < 5; i++)
        {
            if(!myDictionaty.ContainsKey($"Arma {i + 1}")) myDictionaty.Add($"Arma {i + 1}", Random.value * 2);
        }
        if (myDictionaty.TryGetValue(arma, out float temp)) Debug.Log(temp);
        else Debug.Log($"El arma \"{arma}\" no existe");
    }
}
