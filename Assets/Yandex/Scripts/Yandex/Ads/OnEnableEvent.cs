using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnEnableEvent : MonoBehaviour
{
    public UnityEvent OnEvent, OffEvent;
    
    void OnEnable()
    {
        OnEvent.Invoke();
    }

    void OnDisable()
    {
        OffEvent.Invoke();
    }
}
