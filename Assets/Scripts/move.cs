using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    public Vector3 rotation;

    void Update()
    {
        rotation = WorldManager.Instance.worldRotation;

        this.transform.position += 
            (Quaternion.AngleAxis(rotation.y, Vector3.up)
            * new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical"))) 
            * Time.deltaTime * speed;
    }
}