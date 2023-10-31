using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LanePlayer : MonoBehaviour
{
    Transform myTransform;
    float speed = 6;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello World 1");
        Debug.Log("Hello World 3");

        myTransform = GetComponent<Transform>();
        //myTransform.position = new Vector3(myTransform.position.x, myTransform.position.y, 20f);
    }

    // Update is called once per frame
    void Update()
    {
        print("Hello World 2");
        float newX = myTransform.position.x;
        float newY = myTransform.position.y;
        float newZ = myTransform.position.z + speed * Time.deltaTime;
        myTransform.position = new Vector3(newX, newY, newZ);
    }
}
