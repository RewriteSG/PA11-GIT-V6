using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Spawnerscript Spawnerscript;
    public static int Score =0;
    [SerializeField] private Text scoreText;
    public void Start()
    {
        Score = 0;
        scoreText.text = "Score: " + Score;
        instance = this;

    }
    public void UpdateScore()
    {
        Score++;
        scoreText.text = "Score: " + Score;
    }
    public void LoseGame()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void RestartBtn() 
    {
        SceneManager.LoadScene("GameScene");

    }
}
