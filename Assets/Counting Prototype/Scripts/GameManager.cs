using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int time = 15;
    public Text timerText;
    public bool isGameOver = false;
    public GameObject gameOverScreen;
    private Counter counter;
    public Text ast;
    public Text ftst;
    public Text fcst;
    private BallSpawner ballSpawner;
        
    // Start is called before the first frame update
    void Start()
    {
        counter = GameObject.Find("Box").GetComponent<Counter>();
        ballSpawner = GameObject.Find("Ball Spawner").GetComponent<BallSpawner>();
        StartCoroutine(CountDownTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CountDownTimer()
    {
        timerText.text = "Time: " + time;
        while (time != 0 && !isGameOver)
        {
            yield return new WaitForSeconds(1);
            time--;
            timerText.text = "Time: " + time;
        }
        GameOver();
        if (ballSpawner.counter != 0)
        {
            yield return new WaitForSeconds(5);
        }
        ast.text = "Final Score";
        ftst.text = "Time: " + time;
        fcst.text = "Counter: " + counter.count;
    }

    public void GameOver()
    {
        isGameOver = true;
        gameOverScreen.SetActive(true);
        
    }
}
