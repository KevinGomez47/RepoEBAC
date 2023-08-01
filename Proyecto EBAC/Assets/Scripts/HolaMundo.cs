using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("<color=white>Todo esta bien</color>");
        Debug.Log("<color=blue>Todo siguie muy bien</color>", gameObject);
        Debug.LogWarning("<color=yellow>Creo que algo anda mal</color>", gameObject);
        Debug.LogError("<color=red>Algo esta mal</color>", gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
