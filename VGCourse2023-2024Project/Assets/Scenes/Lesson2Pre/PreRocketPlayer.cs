using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreRocketPlayer : MonoBehaviour
{
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Vector3.zero; // new Vector(0, 0, 0)

        //left right forward back
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -5)
            pos.x = -1;
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 5)
            pos.x = 1;
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.z < 5)
            pos.z = 1;
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.z > -5)
            pos.z = -1;

        //units per seconds
        pos.x *= speed * Time.deltaTime;
        pos.z *= speed * Time.deltaTime;

        //switch upside down
        if (Input.GetKeyDown(KeyCode.Space))
            pos.y = -transform.position.y;
        else pos.y = transform.position.y;

        //actual move
        transform.position  = new Vector3(transform.position.x + pos.x, pos.y, transform.position.z + pos.z);
    }

    public void GotHit(PreRocket rocket)
    {
        GameOver();
    }

    void GameOver()
    {
        Debug.Log("Game Over!");
        //this.enabled = false;
    }
}
