using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerMovement : MonoBehaviour
{
    float speed = 1.0f;
    Transform myTransform;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float newX = myTransform.position.x;
        float newY = myTransform.position.y;
        float newZ = myTransform.position.z + speed * Time.deltaTime;
        myTransform.position = myTransform.position + new Vector3(newX, newY, newZ);
    }
}
