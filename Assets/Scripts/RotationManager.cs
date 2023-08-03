using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationManager : MonoBehaviour
{
    public int rotationAmount;
    private Vector3 _leftRotate;
    private Vector3 _rightRotate;

    // Rotating all playground objects
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)){
            foreach (GameObject gameObject in WorldManager.Instance.GetChilderen()){
                _leftRotate = new Vector3(45, gameObject.transform.rotation.eulerAngles.y + rotationAmount ,0);
                gameObject.transform.rotation = Quaternion.Euler(_leftRotate);
            }
            WorldManager.Instance.worldRotation = _leftRotate;
            Debug.Log(WorldManager.Instance.worldRotation);
        }
        if(Input.GetKeyDown(KeyCode.E)){
            foreach (GameObject gameObject in WorldManager.Instance.GetChilderen()){
                _rightRotate = new Vector3(45, gameObject.transform.rotation.eulerAngles.y - rotationAmount ,0);
                gameObject.transform.rotation = Quaternion.Euler(_rightRotate);
            }
            WorldManager.Instance.worldRotation = _rightRotate;
            Debug.Log(WorldManager.Instance.worldRotation);
        }
        
    }
}
