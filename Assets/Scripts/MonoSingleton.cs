using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Base class for all singleton classes
public class MonoSingleton<T> : MonoBehaviour where T: MonoSingleton<T>
{
    public static volatile T instance = null;
    // Start is called before the first frame update
    public static T Instance{
        get{
            if(instance == null){
                instance = FindObjectOfType(typeof(T)) as T;
            }
            return instance;
        }
    }
}
