using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Level1Extras : MonoBehaviour
{
    public Slider slider;
    public Transform player;
    void Start()
    {
       
    }


    void Update()
    {
        if (slider != null)
            slider.value = player.position.z / 68;
    }
}
