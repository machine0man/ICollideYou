using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lasered : MonoBehaviour
{
    public Material m;
    void Start()
    {
        
    }


    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Level2")
        {
            if (transform.position.z > 10)
                gameObject.GetComponent<Renderer>().material = m;

        }

    }
}
