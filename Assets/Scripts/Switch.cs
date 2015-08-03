using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour 
{

    public Control[] ConnectedControls;
    
    public virtual void Activate()
    {
        for (int i = 0; i < ConnectedControls.Length; i++)
        {
            ConnectedControls[i].OnSwitch(true);
        }
    }

    public virtual void Deactivate()
    {
        for (int i = 0; i < ConnectedControls.Length; i++)
        {
            ConnectedControls[i].OnSwitch(false);
        }
    }
}
