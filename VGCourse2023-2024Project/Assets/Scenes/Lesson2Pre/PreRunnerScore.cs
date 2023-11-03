using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreRunnerScore : MonoBehaviour
{
    public int score = 0;
    PreWallLine previousWall;
    Lesson1PrePlayer playerMovement;

    private void Start()
    {
        score = 0;
        previousWall = null;
        playerMovement = GetComponent<Lesson1PrePlayer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
        PreWallLine line = collision.gameObject.GetComponentInParent<PreWallLine>();
        if (line != null)
        {
            if (line != previousWall)
            {
                CompareLane(line);
                previousWall = line;
            }
        }
    }

    void CompareLane(PreWallLine line)
    {
        if (playerMovement.currentLane == line.correctWall)
        {
            score++;
        }
        else
        {
            GameOver();
        }
    }

    void GameOver() {
        Debug.Log("Game Over");
        playerMovement.enabled = false;
    }
}
