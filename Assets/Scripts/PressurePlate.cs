using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PressurePlate : Switch
{
    protected List<GameObject> insideMe = new List<GameObject>();

    private void OnTriggerEnter(Collider e)
     {
         if(e.gameObject != null)
         {
             if(!this.insideMe.Contains(e.gameObject))
             {
                 this.insideMe.Add(e.gameObject);
             }
         }
     }

    private void OnTriggerExit(Collider e)
     {
         if (e.gameObject != null)
         {
             if (this.insideMe.Contains(e.gameObject))
             {
                 this.insideMe.Add(e.gameObject);
             }
         }
     }

    public void Update()
    {
        if (insideMe.Count > 0)
        {
            Activate();
        }
        else
            Deactivate();
    }
}
