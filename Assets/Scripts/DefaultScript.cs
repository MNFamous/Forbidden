using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultScript : MonoBehaviour
{
    private GameObject _thisGameObject;

    //Start function adding the object to the Worldmanager list.
    void Start(){
        _thisGameObject = gameObject;
        WorldManager.Instance.AddChild(_thisGameObject);
        Debug.Log("Object Added to the List");
    }

    //OnDestroy function removing the gameobject from WorldManager list.
    void OnDestroy(){
        WorldManager.Instance.RemoveChild(_thisGameObject);
        Debug.Log("Object Removed From the List");
    }
}
