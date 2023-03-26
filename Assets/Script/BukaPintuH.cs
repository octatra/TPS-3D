using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BukaPintuH : MonoBehaviour
{
    [Header("Main Settings")]
    public string TagObject;
    public UnityEvent TriggerEvent;
    public bool DestroyTrigger;

    public void InvokeTrigger()
    {
        TriggerEvent.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == TagObject)
        {
            TriggerEvent.Invoke();
            if (DestroyTrigger)
            {
                Destroy(other.gameObject);
            }
        }
    }
}
