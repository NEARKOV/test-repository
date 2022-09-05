using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static Beam;

public class CrySheeps : MonoBehaviour
{

    public GameObject SheepWhite;
    public float speed = 5f;
    private Transform sheepBody;
    Vector3 velocity;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.localPosition;
        position.z = 1.5f;
        transform.localPosition = position * Time.deltaTime;


        Vector3 rotation = transform.localRotation.eulerAngles;
        rotation.y = 50f;
        transform.localRotation = Quaternion.Euler(rotation * Time.deltaTime);

    }
}
