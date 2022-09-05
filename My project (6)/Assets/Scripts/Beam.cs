using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    [SerializeField] private Camera _fpcCamera;
    private Ray _ray;
    private RaycastHit hit;

    [SerializeField] private float _maxDistanceRay;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        Ray();
        DrawRay();
        interact();   
    }


    private void Ray()
    {
        _ray = _fpcCamera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
    }

    private void DrawRay()
    {
        if (Physics.Raycast(_ray, out hit, _maxDistanceRay))
        {
            Debug.DrawRay(_ray.origin, _ray.direction * _maxDistanceRay, Color.blue * Time.deltaTime);
        }
        if(hit.transform == null)
        {
            Debug.DrawRay(_ray.origin, _ray.direction * _maxDistanceRay, Color.red * Time.deltaTime);
        }
    }

    private void interact()
    {
        if(hit.transform != null && hit.transform.GetComponent<Door>())
        {
            Debug.DrawRay(_ray.origin, _ray.direction * _maxDistanceRay, Color.green * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.E))
            {
                hit.transform.GetComponent<Door>().Open();
            }
        }
    }
}
