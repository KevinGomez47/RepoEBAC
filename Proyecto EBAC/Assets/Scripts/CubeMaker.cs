using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMaker : MonoBehaviour
{
    Vector3[] vertices =
    {
        new Vector3(0, 0, 0), // Vertice 0
        new Vector3(1, 0, 0), // Vertice 1
        new Vector3(1, 1, 0), // Vertice 2
        new Vector3(0, 1, 0), // Vertice 3
        new Vector3(0, 1, 1), // Vertice 4
        new Vector3(1, 1, 1), // Vertice 5
        new Vector3(1, 0, 1), // Vertice 6
        new Vector3(0, 0, 1) // Vertice 7
    };

    int[] triangles =
    {
        0, 2, 1, // Cara 1
        0, 3, 2,
        2, 3, 4, // Cara 2
        2, 4, 5,
        1, 2, 5, // Cara 3
        1, 5, 6,
        0, 7, 4, // Cara 4
        0, 4, 3,
        5, 4, 7, // Cara 5
        5, 7, 6,
        0, 6, 7, // Cara 6
        0, 1, 6
    };

    GameObject cubeSpawner;
    // Start is called before the first frame update
    void Start()
    {
        cubeSpawner = new GameObject("New Cube");
        cubeSpawner.AddComponent<MeshFilter>();
        var mesh = cubeSpawner.GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.Optimize();
        mesh.RecalculateNormals();
        cubeSpawner.AddComponent<MeshRenderer>();
        var renderer = cubeSpawner.GetComponent<MeshRenderer>().material;
        renderer.color = Color.white;
        cubeSpawner.AddComponent<BoxCollider>();
        var collider = cubeSpawner.GetComponent<BoxCollider>();
        collider.center = new Vector3 (0.5f, 0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
