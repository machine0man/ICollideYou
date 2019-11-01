using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsMoverL1 : MonoBehaviour
{
    public GameObject s1, s2 ,s3 , s4 , b1 , b2 , b3 , b4;
    public Transform player;

    bool forceadded , fa2 , fa3 , fa4;
    void Start()
    {
        forceadded = false;
        fa2 = false;
        fa3 = false; 
        fa4 = false;
    }

   
    void Update()
    {
        if(!forceadded)
                  if (player.position.z >= 25 ) 
        {
            s1.GetComponent<Rigidbody>().AddForce(Vector3.left * 2000);
            s2.GetComponent<Rigidbody>().AddForce(Vector3.right * 2000);
            forceadded = true;
        }
        if(!fa2)
                  if (player.position.z >= 37.5f ) 
        {
            s3.GetComponent<Rigidbody>().AddForce(Vector3.right * 2000);
            s4.GetComponent<Rigidbody>().AddForce(Vector3.left * 2000);
            fa2 = true;
        }

        if (!fa3)
            if (player.position.z >= 45f)
            {
                b1.GetComponent<Rigidbody>().AddForce(Vector3.right * 500);
                b2.GetComponent<Rigidbody>().AddForce(Vector3.left * 500);
                fa3 = true;
            }
        if (!fa4)
            if (player.position.z >= 50f)
            {
                b3.GetComponent<Rigidbody>().AddForce(Vector3.left * 500);
                b4.GetComponent<Rigidbody>().AddForce(Vector3.right * 500);
                fa4 = true;
            }
    }
}
