using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubeFab;
    public List<GameObject> cubeList = new List<GameObject>();
    public float scaleFactor;
    public int cubeNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        cubeNum++;
        GameObject TempGO = Instantiate(cubeFab);
        TempGO.name = "Cube " + cubeNum;

        Color c = new Color(Random.value, Random.value, Random.value);
        TempGO.GetComponent<MeshRenderer>().material.color = c;
        TempGO.transform.position = Random.insideUnitSphere;

        cubeList.Add(TempGO);
        List<GameObject> cubeToDelete = new List<GameObject>();
        foreach(GameObject go in cubeList)
        {
            float scale = go.transform.localScale.x;
            scale *= scaleFactor;
            go.transform.localScale = Vector3.one * scale;
            if(scale <= 0.1f)
            {
                cubeToDelete.Add(go);
            }
        }
        foreach(GameObject go in cubeToDelete)
        {
            cubeList.Remove(go);
            Destroy(go);
        }
    }
}
