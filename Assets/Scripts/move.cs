using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    public Vector3 rotation;
    public Rigidbody rb;

    void Update() {
        rotation = WorldManager.Instance.worldRotation;
    }
    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;
        Vector3 angle = Quaternion.AngleAxis(rotation.y, Vector3.up) * direction;

        rb.velocity = angle * speed;

        //rb.velocity +=
        //    (Quaternion.AngleAxis(rotation.y, Vector3.up)
        //    * new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical"))) 
        //    * Time.deltaTime * speed;
    }
}