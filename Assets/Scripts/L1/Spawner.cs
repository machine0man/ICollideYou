using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    float ex , why , zed , space;
    public GameObject Fsmall_sphere , Esmall_sphere , ECube , FScylinder , EScylinder, EBslab , EScube ;
    public Material m1, m2;
    public GameObject player;

    void Start()
    {
      
        EScube.GetComponent<Renderer>().material = m1;
        Esmall_sphere.GetComponent<Renderer>().material = m1;
        ECube.GetComponent<Renderer>().material = m1;
        EScylinder.GetComponent<Renderer>().material = m1;
        EBslab.GetComponent<Renderer>().material = m1;

        Fsmall_sphere.GetComponent<Renderer>().material = m2;
        FScylinder.GetComponent<Renderer>().material = m2; 

        player.GetComponent<Renderer>().material = m2;








        // A 1  cubes                                                        
        zed = 15; why = 0.5f; ex = -3.75f; space = 1.15f;
        Instantiate(ECube, new Vector3(ex , why , zed), Quaternion.identity);
        Instantiate(ECube, new Vector3(-ex, why, zed), Quaternion.identity);

        ex += space;
        for(int i=0; i<3; i++) 
        { Instantiate(ECube, new Vector3(ex, why, zed), Quaternion.identity);
            Instantiate(ECube, new Vector3(-ex, why, zed), Quaternion.identity);
              zed += space; }
        // 1 FScyliner
        ex = -1.75f; why = 0.2f;zed = 15; space = 0.583f;

        for (int j = 0; j < 6; j++)
        {
            for (int i = 0; i < 7; i++)
            {
                Instantiate(FScylinder, new Vector3(ex, why, zed), Quaternion.identity);
                ex += space;
            }
            ex = -1.75f;
            zed += space;
        }


        //B
        ex = -4; zed = 20;
        for(int i=0;i<3;i++)
        { 
          for(int j=0; j<9;j++)
            {
                Instantiate(FScylinder, new Vector3(ex, why, zed), Quaternion.identity);
                Instantiate(FScylinder, new Vector3(-ex, why, zed), Quaternion.identity);
                zed += space;

            }
            ex += space;zed = 20;
        }

        //c
                        //centre
        zed = 30; ex = -space;why = 0.2f;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Instantiate(EScube, new Vector3(ex, why, zed), Quaternion.identity);
                zed += space;

            }
            ex += space; zed = 30;
        }

        zed = 32.2f; ex = -1.5f; why = 0.5f;

       


        ex = -4; zed = 30; why = 0.25f;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Instantiate(Esmall_sphere, new Vector3(ex, why, zed), Quaternion.identity);
                Instantiate(Esmall_sphere, new Vector3(-ex, why, zed), Quaternion.identity);
                zed += space;

            }
            ex += space; zed = 30;
        }



        //D

        zed = 42.2f; ex = -1.5f; why = 0.5f;

       


        ex = -4; zed = 40; why = 0.25f;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Instantiate(Fsmall_sphere, new Vector3(ex, why, zed), Quaternion.identity);
                Instantiate(Fsmall_sphere, new Vector3(-ex, why, zed), Quaternion.identity);
                zed += space;

            }
            ex += space; zed = 40;
        }



        //E


        ex = -4; zed = 47; why = 0.25f;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Instantiate(Fsmall_sphere, new Vector3(ex, why, zed), Quaternion.identity);
                Instantiate(Fsmall_sphere, new Vector3(-ex, why, zed), Quaternion.identity);
                zed += space;

            }
            ex += space; zed = 47;
        }

        //centre

        ex = -2.34f; zed = 48.749f  ; why = 0.25f;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Instantiate(Fsmall_sphere, new Vector3(ex, why, zed), Quaternion.identity);

                ex += space;

            }
            zed += space; ex = -2.34f;
        }



        //F87
        zed = 54; why = 0.5f; ex = -3.75f; space = 1.15f;
        for (int i = 0; i < 2; i++)
        {
            Instantiate(ECube, new Vector3(ex, why, zed), Quaternion.identity);
            Instantiate(ECube, new Vector3(-ex, why, zed), Quaternion.identity);
            zed += space;
        }

        zed = 54f; space = 0.583f; ; why = 0.25f; ex = -2.34f;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Instantiate(Fsmall_sphere, new Vector3(ex, why, zed), Quaternion.identity);

                ex += space;

            }
            zed += space; ex = -2.34f;
        }

        // G
        zed = 58;ex = 0;
        Instantiate(EBslab, new Vector3(ex, why, zed), Quaternion.Euler(0 , 90, 0));


        zed = 57; why = 0.25f; ex = -4;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Instantiate(Fsmall_sphere, new Vector3(ex, why, zed), Quaternion.identity);
                Instantiate(Fsmall_sphere, new Vector3(-ex, why, zed), Quaternion.identity);
                zed += space;

            }
            ex += space; zed = 57;
        }



    }



}
