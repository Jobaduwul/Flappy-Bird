using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    //public static GameManager instance;
    public GameObject gameOverCanvas;
    public bool gameOver=false;
    public void GameOver()
    {
        gameOver=true;
        Time.timeScale = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if((gameOver)&&(Input.anyKeyDown))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(0);
        }
    }
}
