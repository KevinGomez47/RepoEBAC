using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    //int i;
    private void Awake()
    {
        //Debug.Log("Hola desde Awake");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola desde Start");
        //i = 0;
        //print("<color=white>Todo esta bien</color>");
        //Debug.Log("<color=blue>Todo siguie muy bien</color>", gameObject);
        //Debug.LogWarning("<color=yellow>Creo que algo anda mal</color>", gameObject);
        //Debug.LogError("<color=red>Algo esta mal</color>", gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //i += 1;
        //Debug.Log(i);
        Debug.Log("Hola desde Update");
        
    }

    private void FixedUpdate()
    {
        Debug.Log("Hola desde FixedUpdate");
    }

    private void LateUpdate()
    {
        Debug.Log("Hola desde LateUpdate");
    }

    private void OnEnable()
    {
        Debug.Log("El GO se ha activado");
    }

    private void OnDisable()
    {
        Debug.Log("El GO se ha desactivado");
    }
}
