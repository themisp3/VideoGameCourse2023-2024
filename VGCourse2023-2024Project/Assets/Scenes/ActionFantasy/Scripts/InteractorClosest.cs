using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //TextMeshPro library

public class InteractorClosest : MonoBehaviour
{
    Transform currentInteractableTransform; 
    IInteractable currentInteractable;
    public TextMeshProUGUI outputText;
    float outputTextTimer;
    public float outputTextShowForSeconds = 5f;

    // Start is called before the first frame update
    void Start()
    {
        currentInteractable = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentInteractable != null && Input.GetKeyDown(KeyCode.E))
        {
            currentInteractable.OnInteract(this);
        }

        if (outputTextTimer > 0) outputTextTimer -= Time.deltaTime;

        if (outputTextTimer <= 0)
        {
            outputText?.gameObject.SetActive(false);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Interactable"))
        {
            if (currentInteractable == null)
            {
                IInteractable interactable = other.GetComponent<IInteractable>();
                if (interactable != null)
                {
                    SwitchTarget(other.transform, interactable);
                }
            }
            else if (currentInteractableTransform != other.transform)
            {
                float distCurrent = Vector3.Distance(transform.position, currentInteractableTransform.position);
                float distPotential = Vector3.Distance(transform.position, other.transform.position);
                if (distPotential < distCurrent)
                {
                    IInteractable interactable = other.GetComponent<IInteractable>();
                    if (interactable != null)
                    {
                        SwitchTarget(other.transform, interactable);
                    }
                }
            }
        }
    }

    void SwitchTarget(Transform newTarget, IInteractable newInteractable)
    {
        if (currentInteractable != null) currentInteractable.OnAbortInteract();

        currentInteractable = newInteractable;
        currentInteractableTransform = newTarget;

        currentInteractable.OnReadyInteract();
    }

    public void ReceiveInteract(string message)
    {
        outputTextTimer = outputTextShowForSeconds;
        if (!outputText) return;
        outputText.text = message;
        outputText.gameObject.SetActive(true);
    }
}
