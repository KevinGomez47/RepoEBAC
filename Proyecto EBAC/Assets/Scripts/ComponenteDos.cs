using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponenteDos : MonoBehaviour
{
    private void Awake()
    {
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ComponenteUno.miObjecto.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
