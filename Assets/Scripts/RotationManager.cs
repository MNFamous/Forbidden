using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationManager : MonoBehaviour
{
    private List<GameObject> _objects;
    private Vector3 _leftRotate;
    private Vector3 _rightRotate;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)){
            _objects = WorldManager.Instance.GetAllChilderen();
            foreach (GameObject gameObject in _objects){
                _leftRotate = new Vector3(45, gameObject.transform.rotation.eulerAngles.y + 90 ,0);
                gameObject.transform.rotation = Quaternion.Euler(_leftRotate);
            }
            WorldManager.Instance.worldRotation = _leftRotate;
            Debug.Log(WorldManager.Instance.worldRotation);
        }
        if(Input.GetKeyDown(KeyCode.E)){
            _objects = WorldManager.Instance.GetAllChilderen();
            foreach (GameObject gameObject in _objects){
                _rightRotate = new Vector3(45, gameObject.transform.rotation.eulerAngles.y - 90 ,0);
                gameObject.transform.rotation = Quaternion.Euler(_rightRotate);
            }
            WorldManager.Instance.worldRotation = _rightRotate;
            Debug.Log(WorldManager.Instance.worldRotation);
        }
        
    }
}
