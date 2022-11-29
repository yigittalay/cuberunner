using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    public GameObject GameOver;
    public GameObject completeLevelUI;
    public float restartDelay = 2f;
    bool gameHasEnded = false;


    private void Awake()
    {
        Instance = this;
    }

    public void CompleteLevet()
    {
        completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            GameOver.SetActive(true);
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
