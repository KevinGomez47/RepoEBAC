using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponenteUno : MonoBehaviour
{
    public static GameObject miObjecto;

    private void Awake()
    {
    }
    // Start is called before the first frame update
    void Start()
    {
        miObjecto = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
