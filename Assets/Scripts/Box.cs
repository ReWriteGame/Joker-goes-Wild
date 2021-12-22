using System;
using UnityEngine;
using UnityEngine.Events;

public class Box : MonoBehaviour
{
   public UnityEvent touchPlayerEvent;
   public UnityEvent touchOpenObjectEvent;

 

   private void OnTriggerEnter2D(Collider2D other)
   {
       if(other.gameObject.GetComponent<Player>())
           touchPlayerEvent?.Invoke();
     
       if(other.gameObject.GetComponent<Unpack>())
           touchOpenObjectEvent?.Invoke();
   }
}
