using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject cubePrefavVar;
    private GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 offset = new Vector3(3, 0, 0);
        for (int i=0; i<5; i++)
        {
            cube = Instantiate(cubePrefavVar);
            cube.transform.position = cube.transform.position + i * offset;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
