using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreRocket : PreGoToTarget
{
    public float followingTimer = 3f;

    protected override void Update()
    {
        base.Update();

        //decrease lifetime
        followingTimer -= Time.deltaTime;

        //forget target after seconds
        if (followingTimer <= 0 && target != null) target = null;

        //if you dont have target move forward
        if (!target) transform.position += transform.forward * speed * Time.deltaTime;

        //too long in scene
        if (followingTimer < -15f) SelfDistract();
    }

    //when collided with anything
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Col");
        if (collision.gameObject.CompareTag("Player"))
        {
            PreRocketPlayer player = collision.gameObject.GetComponent<PreRocketPlayer>();
            if (player != null)
            {
                player.GotHit(this);
            }
            SelfDistract();
        }
        else
        {
            SelfDistract();
        }
    }

    void SelfDistract()
    {
        //Destroy(this);
        Destroy(gameObject);
    }
}
