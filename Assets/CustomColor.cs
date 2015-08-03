using UnityEngine;
using System.Collections;

public class CustomColor : MonoBehaviour 
{
    public Color color;
    public bool EachFrame;

    public void Start()
    {
        GetComponent<Renderer>().material.color = color;

    }
    public void Update()
    {
        if (EachFrame)
            GetComponent<Renderer>().material.color = color;
    }

	
}
