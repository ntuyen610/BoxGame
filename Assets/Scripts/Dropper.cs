using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    Rigidbody rigidBody;
    [SerializeField] float dropTime = 3f;

    void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
        rigidBody = GetComponent<Rigidbody>();


        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > dropTime)
        {
            GetComponent<MeshRenderer>().enabled = true;
            rigidBody.useGravity = true;
        }


    }
}
