using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractJumper : MonoBehaviour, IInteractable
{
    public Rigidbody body;
    public void OnAbortInteract()
    {
        //throw new System.NotImplementedException();
    }

    public void OnEndInteract()
    {
        //throw new System.NotImplementedException();
    }

    public void OnInteract(InteractorClosest interactor)
    {
        //throw new System.NotImplementedException();
        body.AddForce(Vector3.up * 10, ForceMode.Impulse);

    }

    public void OnReadyInteract()
    {
        //throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
