using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.S))
      {
         DelegateManager.scoreEvent?.Invoke();
      }
      if (Input.GetKeyDown(KeyCode.D)
      {
         DelegateManager.scoreEvent?.Invoke();
      }
   }
}
