using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnActivate : MonoBehaviour
{
   public UnityEvent OnActivateObject;

   void OnEnable()
   {
        OnActivateObject.Invoke();
   }
}
