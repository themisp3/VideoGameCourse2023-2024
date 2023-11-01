using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1PrePlayer : MonoBehaviour
{
    public float speed = 1.0f;
    public float laneSpeed = 1.0f;
    public int currentLane;

    // Start is called before the first frame update
    void Start()
    {
        currentLane = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (currentLane > -2)
                currentLane--;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentLane < 2)
                currentLane++;
        }

        float newX = transform.position.x + (currentLane * 5 - transform.position.x) * laneSpeed;
        float newY = transform.position.y;
        float newZ = transform.position.z + speed * Time.deltaTime;
        transform.position = new Vector3(newX, newY, newZ);
    }
}
