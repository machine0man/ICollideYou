using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JohnCenaScript : MonoBehaviour
{
    public Transform referee;
    float refereeZ;
    public float force = 1f;
    public Transform Player;
    public float PlayerSpeed;
    float vert, hori;
    public JoystickScript Joystick;
    Rigidbody r;
    Vector3 lower, upper;

    bool fin;
    public PlayerScript s;

    public float Ulimit{ set; get; }
    public float Llimit { set; get; }

    void Start()
    {
       
        PlayerSpeed = 75f;
        r = GetComponent<Rigidbody>();

        // to find the upper and lower limit of Screen with raycasting
        refereeZ = referee.position.z;
        Vector3 far = new Vector3(Screen.width / 2, 0, Camera.main.farClipPlane);
        Vector3 near = new Vector3(Screen.width / 2, 0, Camera.main.nearClipPlane);
        Vector3 farpos = Camera.main.ScreenToWorldPoint(far);
        Vector3 nearpos = Camera.main.ScreenToWorldPoint(near);
        RaycastHit hit;

        if (Physics.Raycast(nearpos, farpos - nearpos, out hit))
            lower = hit.point + new Vector3(0, 0, 1);

        far = new Vector3(Screen.width / 2, Screen.height, Camera.main.farClipPlane);
        near = new Vector3(Screen.width / 2, Screen.height, Camera.main.nearClipPlane);
        farpos = Camera.main.ScreenToWorldPoint(far);
        nearpos = Camera.main.ScreenToWorldPoint(near);

        if (Physics.Raycast(nearpos, farpos - nearpos, out hit))
            upper = hit.point + new Vector3(0, 0, -0.5f);
    }

    void Update()
    {
        if(s!= null)
        fin = s.finished;
   
        // MouseInputs();
        transform.Translate(Vector3.forward * 3 * Time.deltaTime);
        if (!fin)
            TouchInputs();

    }





    void MouseInputs()
    {
      
        hori = Input.GetAxis("Mouse X");
        vert = Input.GetAxis("Mouse Y");
        if (vert > 0 || vert < 0 || hori > 0 || hori < 0)
        {
            transform.Translate(Vector3.forward * vert * PlayerSpeed * 1.5f * Time.deltaTime);
            transform.Translate(Vector3.right * hori * PlayerSpeed * Time.deltaTime);
        }
    }

    void TouchInputs()
    {

        Vector3 dir = Joystick.InputDirection;

        hori = dir.x;
        vert = dir.z;
        {



            transform.Translate(Vector3.forward * vert * PlayerSpeed *1.5f * Time.deltaTime);
            transform.Translate(Vector3.right * hori * PlayerSpeed * Time.deltaTime);

            //detecting collisions at sides of the base
            if (transform.position.x < -4.1) transform.position = new Vector3(-4.1f, transform.position.y, transform.position.z);
            if (transform.position.x > 4.1) transform.position = new Vector3(4.1f, transform.position.y, transform.position.z);


            //detecting collisions at upper and lower part of Screen
            Ulimit = upper.z - refereeZ + referee.position.z;
            Llimit = lower.z - refereeZ + referee.position.z;
            if(transform.position.z > Ulimit) transform.position = new Vector3(transform.position.x , transform.position.y, Ulimit);
            if (transform.position.z < Llimit) transform.position = new Vector3(transform.position.x, transform.position.y, Llimit);
        }
    }
}
