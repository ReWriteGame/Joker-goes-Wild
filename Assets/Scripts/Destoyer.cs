using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destoyer : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other)
   {
     if(other.gameObject.GetComponent<Box>())
         other.gameObject.GetComponent<Destroyable>().Destroy();
   }
}
