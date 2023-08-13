using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeManager : MonoBehaviour
{
    public SlimeScriptableObject greenSlime;
    private Rigidbody _rb;
    private Vector3 _targetPosition;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _targetPosition = other.transform.position.normalized;
            _rb.velocity = _targetPosition * greenSlime.speed;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _rb.velocity = Vector3.zero;
        }
    }
    void Start()
    {
        _rb = GetComponent<Rigidbody>(); 
    }


    void Update()
    {
        
    }
}
