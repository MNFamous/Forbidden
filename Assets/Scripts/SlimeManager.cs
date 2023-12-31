using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SlimeManager : MonoBehaviour
{
    public SlimeScriptableObject greenSlime;
    public GameObject target;
    public float followDistance;
    private Rigidbody _rb;
    private Vector3 _direction;
    private Vector3 _difference;
    private Vector3 _velocity;

    private bool _playerInsight;
    private bool _playerTouching;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            target = other.gameObject;
            _playerInsight = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            target = other.gameObject;
            _rb.velocity = Vector3.zero;
            _playerInsight = false;
        }
    }
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Player")) {
            //other.gameObject.GetComponent<PlayerManager>().TakeDamage(greenSlime.damage);

            //Stop the slime
            _playerTouching = true;
            _rb.velocity = Vector3.zero;
        }
    }
    private void OnCollisionExit(Collision other) {
        if (other.gameObject.CompareTag("Player")) {
            _playerTouching = false;
        }
    }
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (_playerInsight && !_playerTouching) MoveTorwardsEntity(_rb, target, greenSlime.speed);
    }
    protected void MoveTorwardsEntity(Rigidbody entity, GameObject target, float speed) {
        _difference = target.transform.position - entity.transform.position;
        Debug.Log(_difference);
        if((_difference.x <= followDistance && _difference.x >=-followDistance) && (_difference.z <=followDistance && _difference.z >= -followDistance)) return;
        _direction = _difference.normalized;
        _velocity = _direction * speed;
        entity.velocity = _velocity;
    }
}
