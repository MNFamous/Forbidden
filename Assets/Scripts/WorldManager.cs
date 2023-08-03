using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class containing all activities and objects about world.
public class WorldManager : MonoSingleton<WorldManager>
{
    public Vector3 worldRotation = new Vector3(45,0,0);
    private List<GameObject> _playgroundObjects;

    void Start()
    {
        _playgroundObjects = new List<GameObject>();
    }
    
    //Adding received child to the child list
    public void AddChild(GameObject obj)
    {
        _playgroundObjects.Add(obj);
    }

    //Removing received child to the child list
    public void RemoveChild(GameObject obj){
        _playgroundObjects.Remove(obj);
    }

    //Getter for receiving all the object childeren in Playground
    public List<GameObject> GetChilderen()
    {
            return _playgroundObjects;
    }

}
