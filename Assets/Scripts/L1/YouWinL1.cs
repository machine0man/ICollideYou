using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWinL1 : MonoBehaviour
{
    public MenuScript menuscript;
    public Transform player;
    public PlayerScript p; 
    void Update()
    {
           if (player.position.z >= 68f)
        {
            p.finished = true;
            menuscript.YouWin();
        }

    }
}
