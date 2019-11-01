using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerL2 : MonoBehaviour
{

    float ex, why, zed, space;
    public GameObject Fcylinder, FScube ,Ecube , EScube , Fcube , ESsphere  , FScylinder;
   
    public GameObject player;
 
    public Material m1, m2;
    public int LayerEnemy { set; get;  }

    void Start()
    {
       LayerEnemy = 11;



        Ecube.GetComponent<Renderer>().material = m2;// change cl after lasering
        EScube.GetComponent<Renderer>().material = m1;
        ESsphere.GetComponent<Renderer>().material = m1;
        Fcylinder.GetComponent<Renderer>().material = m2;
        FScube.GetComponent<Renderer>().material = m2;
        player.GetComponent<Renderer>().material = m1;
        FScylinder.GetComponent<Renderer>().material = m1; // chng color after lasering
        Fcube.GetComponent<Renderer>().material = m2;






        zed = 0; why = 0.5f; ex = -3.75f; space = 1.15f;
        Instantiate(Ecube, new Vector3(ex, why, zed), Quaternion.identity);
        Instantiate(Ecube, new Vector3(-ex, why, zed), Quaternion.identity);

        ex += space;
        for (int i = 0; i < 8; i++)
        {
            Instantiate(Ecube, new Vector3(ex, why, zed), Quaternion.identity);
            Instantiate(Ecube, new Vector3(-ex, why, zed), Quaternion.identity);
            zed += space;
        }
        // 1 FScyliner
        ex = -1.75f; why = 0.2f; zed = 0; space = 0.583f;

        for (int j = 0; j < 17; j++)
        {
            for (int i = 0; i < 7; i++)
            {
                Instantiate(FScylinder, new Vector3(ex, why, zed), Quaternion.identity);
                ex += space;
            }
            ex = -1.75f;
            zed += space;
        }







        ex = 0.3f ;why = 0.9f ; zed =15 ; space = 0.6f; ;


        // A

        for (int i = 0; i < 14; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (!((i == 11 || i == 12) && (j == 0 || j == 1)))
                {
                    if (!((i == 6 || i == 7) && (j == 4 || j == 5 || j == 6 || j == 7)))
                        Instantiate(Fcylinder, new Vector3(ex, why, zed), Quaternion.identity);
                    if (!((i == 2 || i == 3) && (j == 4 || j == 5 || j == 6 || j == 7))
                      )
                        Instantiate(Fcylinder, new Vector3(-ex, why, zed), Quaternion.identity);

                }

                ex+= space;

            }
            ex = 0.3f; zed += space;
        }


        // B 
        space = 0.583f;
          zed = 28.3f; ex = -space;why = 0.2f;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Instantiate(FScube, new Vector3(ex, why, zed), Quaternion.identity);
                zed += space;

            }
            ex += space; zed = 28.3f;
        }

   ex = -1.2f; zed = 30f;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Instantiate(FScube, new Vector3(ex, why, zed), Quaternion.identity);
                Instantiate(FScube, new Vector3(-ex, why, zed), Quaternion.identity);
                zed += space;

            }
            ex -= space; zed = 30f;
        }
        zed = 33.5f; ex = -space;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Instantiate(FScube, new Vector3(ex, why, zed), Quaternion.identity);
                zed += space;

            }
            ex += space; zed = 33.5f;
        }
        zed =28.3f; why = 0.5f; ex = -3.75f; space = 1.15f;

        Ecube.GetComponent<Renderer>().material = m1;
        for (int i=0;i<7;i++)
        {
            Instantiate(Ecube, new Vector3(ex, why, zed), Quaternion.identity);
            Instantiate(Ecube, new Vector3(-ex, why, zed), Quaternion.identity);
            zed += space;

        }


         // C
        zed = 40.7f; ex = 0.29f;space = 0.583f;why = 0.2f;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Instantiate(EScube, new Vector3(ex, why, zed), Quaternion.identity);
                Instantiate(EScube, new Vector3(-ex, why, zed), Quaternion.identity);
                ex += space;

            }
            zed += space; ex = 0.29f;
        }
        // D


        zed = 45;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Instantiate(FScube, new Vector3(ex, why, zed), Quaternion.identity);
                Instantiate(FScube, new Vector3(-ex, why, zed), Quaternion.identity);
                ex += space;

            }
            zed += space; ex = 0.29f;
        }


        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Instantiate(FScube, new Vector3(ex, why, zed), Quaternion.identity);
                Instantiate(FScube, new Vector3(-ex, why, zed), Quaternion.identity);
                ex += space;

            }
            zed += space; ex = 0.29f;
        }

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Instantiate(FScube, new Vector3(ex, why, zed), Quaternion.identity);
                Instantiate(FScube, new Vector3(-ex, why, zed), Quaternion.identity);
                ex += space;

            }
            zed += space; ex = 0.29f;
        }



        // E
        zed = 59;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Instantiate(FScube, new Vector3(ex, why, zed), Quaternion.identity);
                Instantiate(FScube, new Vector3(-ex, why, zed), Quaternion.identity);
                ex += space;

            }
            zed += space; ex = 0.29f;
        }


         // F
        zed += 5;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Instantiate(FScube, new Vector3(ex, why, zed), Quaternion.identity);
                Instantiate(FScube, new Vector3(-ex, why, zed), Quaternion.identity);
                ex += space;

            }
            zed += space; ex = 0.29f;
        }

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Instantiate(FScube, new Vector3(ex, why, zed), Quaternion.identity);
                Instantiate(FScube, new Vector3(-ex, why, zed), Quaternion.identity);
                ex += space;

            }
            zed += space; ex = 0.29f;
        }

        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Instantiate(FScube, new Vector3(ex, why, zed), Quaternion.identity);
                Instantiate(FScube, new Vector3(-ex, why, zed), Quaternion.identity);
                ex += space;

            }
            zed += space; ex = 0.29f;
        }
        ex = -4; zed = 66;space = 1.15f;
        for (int i = 0; i < 13; i++)
        {
            Instantiate(Ecube, new Vector3(ex, why, zed), Quaternion.identity);
            Instantiate(Ecube, new Vector3(-ex, why, zed), Quaternion.identity);
            zed += space;

        }

        // last line
        zed = 81f; ex = 0.29f; space = 0.583f; why = 0.2f;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Instantiate(ESsphere, new Vector3(ex, why, zed), Quaternion.identity);
                Instantiate(ESsphere, new Vector3(-ex, why, zed), Quaternion.identity);
                ex += space;

            }
            zed += space; ex = 0.29f;
        }


    }

     void Update()
    {
        Laserit();
    }

    void Laserit()
    {

        if (player.GetComponent<Transform>().position.z > 10 && player.GetComponent<Renderer>().material != m2)
        {
            player.GetComponent<Renderer>().material = m2;


        }


    }


}
