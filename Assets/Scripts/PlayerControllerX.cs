using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool hasSpawned = false;

    
    // Update is called once per frame
    void Update()
    {
        //A dog will spawn when space is pressed and no dog has spawned otherwise nothing will spawn
        if (Input.GetKeyDown(KeyCode.Space) && hasSpawned == false)
        {
            StartCoroutine(SpawnDogs());
        }
    }

    private IEnumerator SpawnDogs()
    {
        //this will tell the game the dog has spawned when the Space is pressed
        hasSpawned = true;
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

        //wait for 2 secs before the dog can be spawned again
        yield return new WaitForSeconds(2.0f);
        hasSpawned = false;

    }
}
