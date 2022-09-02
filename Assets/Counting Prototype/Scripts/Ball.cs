using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private BallSpawner counter;
    private GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        counter = GameObject.Find("Ball Spawner").GetComponent<BallSpawner>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -2)
        {
            Destroy(gameObject);
            counter.counter--;
            if (counter.counter == 0)
            {
                gameManager.GameOver();
            }
        }
    }
}
