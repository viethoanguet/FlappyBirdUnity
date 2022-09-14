using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Text textScore;
    public GameObject playButtom;
    public GameObject imgGameOver;
    public Player player;
    private int score;
    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }
    public void IncreaseScore()
    {
        score++;
        textScore.text = score.ToString();
    }
    public void GameOver()
    {
        imgGameOver.SetActive(true);
        playButtom.SetActive(true);
        Pause();
    }
    public void Play()
    {
        score = 0;
        textScore.text = score.ToString();
        playButtom.SetActive(false);
        imgGameOver.SetActive(false);
        Time.timeScale = 1f;
        player.enabled = true;

        Pipe[] pipes = FindObjectsOfType<Pipe>();
        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }

    }
    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }
}
