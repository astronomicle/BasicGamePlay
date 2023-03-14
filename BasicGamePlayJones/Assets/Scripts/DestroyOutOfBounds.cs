using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -20;
    private float leftBound = -50;
    private float rightBound = 50;

    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        } 
        else if(transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
