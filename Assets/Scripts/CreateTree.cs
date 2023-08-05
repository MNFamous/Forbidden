using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTree : MonoBehaviour
{
    private float _firstLeftClick;
    private bool _isAllowed = true;
    private int _clickNum = 0;
    public float timeBetween;
    public GameObject tree;
    public GameObject playground;
    RaycastHit hit;
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 100))
        {
            Debug.DrawLine(ray.origin, hit.point, Color.green);
            Debug.DrawLine(hit.point, new Vector3(hit.point.x, 10 , hit.point.z), Color.green, 2f);
        }
        if(Input.GetMouseButtonUp(0))
        {
            _clickNum++;
        }
        if(_clickNum == 1 && _isAllowed == true)
        {
            _firstLeftClick = Time.time;
            StartCoroutine(DoubleClick());
        }
    }

    //Checking double click
    IEnumerator DoubleClick()
    {
        _isAllowed = false;
        while( Time.time < _firstLeftClick + timeBetween)
        {
            if(_clickNum == 2)
            {
                Create();
                break;
            }
            yield return new WaitForEndOfFrame();
        }
        _clickNum = 0;
        _isAllowed = true;
    }

    //Creating Tree in intended position
    private void Create(){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100))
            {
                Instantiate(tree,new Vector3(hit.point.x,0.3774824f,hit.point.z), Quaternion.identity, playground.transform);
                Debug.Log(hit.point);
            }
    }
}
