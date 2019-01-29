using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChanger : MonoBehaviour
{
    int counter;
    Vector3 side, top;
    float panSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        side = new Vector3(6, 2, 12);
        top = new Vector3(0, 20, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Rotate();
        }
    }

    void Rotate()
    {
        if (counter % 2 == 0)
        {
            transform.position = top;
            transform.eulerAngles = new Vector3(90, 0, 180);
            counter++;
        }
        else
        {
            gameObject.transform.position = side;
            transform.eulerAngles = new Vector3(170, 40, 180);
            counter++;
        }
    }
}
