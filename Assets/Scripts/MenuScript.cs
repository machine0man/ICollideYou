using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public GameObject backbtnPanel;

    public Transform player;
    public GameObject GameoverPanel;
    public GameObject youwinPanel;
     void Start()
    {
        Time.timeScale = 1;
    }
    void Update()
    {
       

          if((Input.GetKeyUp(KeyCode.Escape ) || Input.GetKeyUp(KeyCode.Q)) && !GameoverPanel.activeSelf )
        {

            Time.timeScale = 0;
            backbtnPanel.SetActive(true);
        }


    }

    public void PlayGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    public void OpenMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Resume()
    {
        Time.timeScale = 1;
        backbtnPanel.SetActive(false);

    }

    public void Restart()
    {
        Time.timeScale = 1;
       
        SceneManager.LoadScene(1);
    }

    public void GameOver()
    {
        if (!youwinPanel.activeSelf)
        {
            Handheld.Vibrate();
            Time.timeScale = 0.05f;
            GameoverPanel.SetActive(true);
        }
    }
    public void YouWin()
    {
        if (!GameoverPanel.activeSelf) {
            youwinPanel.SetActive(true);
            Time.timeScale = 0.05f;
        }
    }
    public void Level2()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(2);
    }
}
