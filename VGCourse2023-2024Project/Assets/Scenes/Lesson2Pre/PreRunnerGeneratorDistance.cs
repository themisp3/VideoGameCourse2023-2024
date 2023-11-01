using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreRunnerGeneratorDistance : MonoBehaviour
{
    public Transform player;
    public GameObject[] walls;
    public float wallsDistance = 20;
    public int preloadWalls = 10;
    int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // playerZ (60) / wallD(20) < preloadW(10) + index(5)
        if (player.position.z / wallsDistance + preloadWalls > index)
        {
            SpawnWall();
        }
    }

    void SpawnWall()
    {
        GameObject picked = walls[Random.Range(0, walls.Length)];
        Vector3 pos = transform.position + new Vector3(0, 0, index * wallsDistance);

        GameObject clone = GameObject.Instantiate(picked, pos, Quaternion.identity);
        
        index++;
    }
}
