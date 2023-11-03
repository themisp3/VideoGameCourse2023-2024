using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LanePlayer : MonoBehaviour
{
    Transform myTransform;
    [SerializeField] private float speed = 6;
    [SerializeField] private float laneSpeed = 5;
    int currentLane = 0;
    public float laneWidth = 5f;

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
            {
                currentLane--;
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentLane < 2)
            {
                currentLane++;
            }
        }

        float newX = transform.position.x + (currentLane * laneWidth - transform.position.x) * laneSpeed * Time.deltaTime;
        float newY = transform.position.y;
        float newZ = transform.position.z + speed * Time.deltaTime;
        transform.position = new Vector3(newX, newY, newZ);
    }
}
