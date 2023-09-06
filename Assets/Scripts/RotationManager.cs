using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationManager : MonoSingleton<RotationManager>
{
    public int rotationAmount;
    private Vector3 _leftRotate;
    private Vector3 _rightRotate;

    // Rotating all playground objects
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)){
            RotateLeft();
        }
        if(Input.GetKeyDown(KeyCode.E)){
            RotateRight();
        }
        
    }

    //Rotating objects to the left
    public void RotateLeft()
    {
        foreach (GameObject gameObject in WorldManager.Instance.GetChilderen())
        {
            _leftRotate = new Vector3(WorldManager.Instance.worldRotation.x, gameObject.transform.rotation.eulerAngles.y + rotationAmount ,0);
            gameObject.transform.rotation = Quaternion.Euler(_leftRotate);
        }
        WorldManager.Instance.worldRotation = _leftRotate;
        Debug.Log(WorldManager.Instance.worldRotation);
    }

    //Rotating objects to the right
    public void RotateRight(){
            foreach (GameObject gameObject in WorldManager.Instance.GetChilderen()){
                _rightRotate = new Vector3(45, gameObject.transform.rotation.eulerAngles.y - rotationAmount ,0);
                gameObject.transform.rotation = Quaternion.Euler(_rightRotate);
            }
            WorldManager.Instance.worldRotation = _rightRotate;
            Debug.Log(WorldManager.Instance.worldRotation);
    }
}
