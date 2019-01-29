using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetObject : MonoBehaviour
{
    public Vector3 origPosition;
    public GameObject obj;
    private int layerMask = 1<<9;
    // Start is called before the first frame update
    void Start()
    {
        //origPosition = obj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f, layerMask))
            {
                if (hit.rigidbody)
                {
                    Reset(hit.rigidbody.gameObject);
                }
            }
        }
    }

    private void Reset(GameObject go)
    {
        go.transform.position = origPosition;
    }
}
