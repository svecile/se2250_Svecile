using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBox : MonoBehaviour
{
    private int layerMask = 1 << 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f,layerMask))
            {
                if (hit.rigidbody)
                {
                    ChangeAngle(hit.transform.gameObject);
                }
            }
        }
    }

    private void ChangeAngle(GameObject go)
    {
       go.transform.Rotate(-20,0,0);
    }
}
