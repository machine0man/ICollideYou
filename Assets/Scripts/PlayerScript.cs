using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerScript : MonoBehaviour
{
    public Transform t;
    Vector3 curPos;
    public float smoothness;
   
    public bool finished {  set; get; }
    public JohnCenaScript j;
    Rigidbody r;

    public MenuScript menuscript;
    public Material m1, m2;
    public SpawnerL2 script;

    bool  firsttime;
    void Start()
    {
        firsttime = true;
       
    
        smoothness = 0.15f;
        curPos = transform.position;
        finished = false;
        r = GetComponent<Rigidbody>();
    
    }


    void Update()
    {


        curPos = Vector3.Lerp(transform.position, t.position, smoothness);
        transform.position = curPos;


      

    }
  


    void OnCollisionEnter(Collision collision)
    {
        if(script != null)
        if (collision.gameObject.layer == script.LayerEnemy && SceneManager.GetActiveScene().name == "Level2")
        {
         
            if (firsttime)
            {
                menuscript.GameOver();
                firsttime = false;
            }

        }

           if (SceneManager.GetActiveScene().name == "Level1"  && collision.gameObject.layer == 11)  // for level 1
        {

          
         
                if (firsttime)
                {

                    
                    menuscript.GameOver();
                    firsttime = false;
                }

        }


    }




}
