using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    public float spawnInterval = 4.0f; //made the interval code public to show the values changing
    private int randomNum;

    void Start()
    {
        //sawnInterval is changing inside the SpawnRandomBall Method
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        randomNum = Random.Range(0, ballPrefabs.Length);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randomNum], spawnPos, ballPrefabs[randomNum].transform.rotation);

        // this changes the interval time after it calls the method, changing the spawn times
        spawnInterval = Random.Range(3.0f, 5.0f);

    }

}
