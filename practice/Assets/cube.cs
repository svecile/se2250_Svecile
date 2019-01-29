using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        Vector3 move = Vector3.zero;

        float speed = 0.01f;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            move = Vector3.right;
        } else if (Input.GetKey(KeyCode.LeftArrow))
        {
            move = Vector3.left;
        }
        //gameobject is current game object
        gameObject.transform.position = gameObject.transform.position + move * speed;
    }
}
