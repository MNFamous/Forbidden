using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoSingleton<WorldManager>
{
    public Vector3 worldRotation = new Vector3(45,0,0);
    private List<GameObject> _playgroundObjects;

    void Start()
    {
        _playgroundObjects = new List<GameObject>();
    }
    
    public List<GameObject> GetAllChilderen()
    {
        _playgroundObjects.Clear();
        foreach (Transform child in transform)
        {
            Debug.Log(child);
            _playgroundObjects.Add(child.gameObject);
        }
        return _playgroundObjects;
    }
}
