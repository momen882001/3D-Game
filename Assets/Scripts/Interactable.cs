using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public bool useEvents;
    // message displayed to player when looking at interactable
    [SerializeField]
    public string promptMessage;

    // this function will be called from our player
    public void BaseInteract()
    {
        if (useEvents)
        {
            GetComponent<InteractionEvent>().onInteract.Invoke();
        }
        Interact();
    }


    protected virtual void Interact()
    {

    }
}
