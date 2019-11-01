using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    float CameraSpeed;
    void Start()
    {
        CameraSpeed = 3f;

    }

    void Update()
    {
       transform.Translate(Vector3.forward * CameraSpeed * Time.deltaTime);
    }
}
