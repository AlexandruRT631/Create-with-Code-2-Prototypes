using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public float range = 9;
    public GameObject ball;
    public int numberOfBalls;
    
    // Start is called before the first frame update
    void Start()
    {
        while (numberOfBalls != 0)
        {
            Instantiate(ball,
                new Vector3(Random.Range(-range, range), Random.Range(10, 14), Random.Range(-range, range)),
                ball.transform.rotation);
            numberOfBalls--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
