using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            this.transform.position += (new Vector3(0,0,1)) * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.A)){
            this.transform.position += (new Vector3(-1,0,0)) * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D)){
            this.transform.position += (new Vector3(1,0,0)) * Time.deltaTime * speed; 
        }
        if (Input.GetKey(KeyCode.S)){
            this.transform.position += (new Vector3(0,0,-1)) * Time.deltaTime * speed;
        }
    }
}
