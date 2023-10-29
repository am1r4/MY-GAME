using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFloat : MonoBehaviour
{
    public float rotationSpeed = 10f;
      void Start()
    {
        Debug.Log(transform.position);

    }

    void Update()
    {

    transform.RotateAround(transform.position, Vector3.up, 10f * Time.deltaTime);

      
    }
}

