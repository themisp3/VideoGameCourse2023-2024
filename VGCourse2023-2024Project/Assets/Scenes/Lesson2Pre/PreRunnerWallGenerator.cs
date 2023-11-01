using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreRunnerWallGenerator : MonoBehaviour
{
    public float spawnDelay = 3f;
    float timer = 0;
    public GameObject[] walls;

    // Start is called before the first frame update
    void Start()
    {
        timer = spawnDelay;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= spawnDelay)
        {
            timer = 0;

            SpawnWall();
        }
        timer += Time.deltaTime;
    }

    void SpawnWall()
    {
        GameObject picked = walls[Random.Range(0, walls.Length)];
        GameObject clone = GameObject.Instantiate(picked, transform.position, Quaternion.identity);
    }
}
