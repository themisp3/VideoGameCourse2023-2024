using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreGoToTarget : MonoBehaviour
{
    //public Vector3 position;
    public Transform target;
    public float speed = 1f;
    public float rotateSpeed = 1f;
    public float stoppingDistance = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if (target == null) return;

        Vector3 diff = target.position - transform.position;
        Vector3 dir = diff.normalized;
        Debug.DrawLine(transform.position, transform.position + dir, Color.red);
        if (diff.magnitude > stoppingDistance)
        {
            transform.position += dir * speed * Time.deltaTime;
            transform.forward += dir * rotateSpeed * Time.deltaTime;
        }
    }
}
