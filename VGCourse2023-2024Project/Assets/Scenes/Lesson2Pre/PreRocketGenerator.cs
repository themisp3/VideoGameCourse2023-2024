using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreRocketGenerator : MonoBehaviour
{
    public Transform player;
    public GameObject rocketOriginal;
    public float tick = 1;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= tick) {
            timer = 0;

            SpawnRocket();
        }
    }

    void SpawnRocket() {
        Vector3 pos = Vector3.zero;
        //      10 to 20 multiplied by -1 or 1
        pos.x = Random.Range(10f, 20f) * ((Random.Range(0, 2) * 2) - 1);
        pos.y = Random.Range(0f, 5f) * ((Random.Range(0, 2) * 2) - 1);
        pos.z = Random.Range(10f, 20f) * ((Random.Range(0, 2) * 2) - 1);

        GameObject clone = GameObject.Instantiate(rocketOriginal, pos, Quaternion.identity);
        clone.transform.LookAt(player);
        clone.SetActive(true);
    }
}
