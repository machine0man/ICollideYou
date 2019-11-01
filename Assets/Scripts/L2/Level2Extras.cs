using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Level2Extras : MonoBehaviour
{
    public Slider slider;
    public Transform player;
    public MenuScript menuscript;
    public PlayerScript p;
    void Start()
    {

    }


    void Update()
    {
        if (slider != null)
            slider.value = player.position.z / 84;

        if (player.GetComponent<Transform>().position.z >= 84f)
        {
            p.finished = true;
            menuscript.YouWin();
        }
    }
}
