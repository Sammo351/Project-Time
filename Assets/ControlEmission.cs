using UnityEngine;
using System.Collections;

public class ControlEmission : MonoBehaviour 
{

    public Gradient gradient;

    float time = 0;
    public float Seconds = 3;
    public float AlphaMultiplier = 3;

    void Start()
    {
        time = 0;
    }

    public void Update()
    {
        time += Time.deltaTime;

        GetComponent<Renderer>().material.SetColor("_EmissionColor", gradient.Evaluate(time / Seconds));
        GetComponent<Renderer>().material.SetColor("_Color", gradient.Evaluate(time / Seconds));
        DynamicGI.SetEmissive(GetComponent<Renderer>(), gradient.Evaluate(time / Seconds) * AlphaMultiplier);
        

    }


}
