using UnityEngine;
using System.Collections;

public class Gate : Control 
{

    ControlEmission emission;



    public override void OnSwitch(bool state)
    {
        if (state)
        {
            emission.enabled = true;
            emission.gradient.colorKeys[0] = emission.gradient.colorKeys[1];
            emission.gradient.colorKeys[1] = new GradientColorKey(Color.green, 1);
        }
        else
        if (!state)
        {
            emission.enabled = true;
            emission.gradient.colorKeys[0] = emission.gradient.colorKeys[1];
            emission.gradient.colorKeys[1] = new GradientColorKey(Color.red, 1);
        }
    }
}
