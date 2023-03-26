using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Quest : MonoBehaviour
{
    [Header("Main Setting")]
    public string TagObject;
    public UnityEvent TriggerEvents;
    public bool DestroyTrigger;
    public float Dialogue;

    public void InvokeTrigger()
    {
        TriggerEvents.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == TagObject)
        {
            TriggerEvents.Invoke();
            if (DestroyTrigger)
            {
                Destroy(other.gameObject);
            }

        }
    }
}
