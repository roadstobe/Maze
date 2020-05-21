using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization;

public class GameManager : MonoBehaviour
{
    public GameObject panelUI;
    public GameObject scoreUI;
    public GameObject mainMenu;

    bool gameHasEnded = false;

    public float restartTime;

    public Transform playerTransform;

    public int needKeys = 1;
    public int keys;
    private bool isPause = false;

    private void Start()
    {
    }
    private void Update()
    {
        if (Input.GetKey("p") && isPause == false)
        {
            Time.timeScale = 0;
            panelUI.SetActive(true);
            isPause = true;
        }
        else if (Input.GetKey(KeyCode.Escape) && isPause == true)
        {
            Time.timeScale = 1;
            isPause = false;
            panelUI.SetActive(false);
        }
    }

    public void FinishGame()
    {
        Time.timeScale = 0;
        scoreUI.SetActive(true);
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("RestartGame", restartTime);
        }
    }
    public void RestartGame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    public void SetDificult(int keys)
    {
       
        Debug.Log("Dificult");
        needKeys = keys;
        Debug.Log(needKeys);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
