using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setLedColor : MonoBehaviour
{
    Renderer ledRenderer;
    void Start()
    {
        ledRenderer = GetComponent<Renderer>();
        ledRenderer.material.color = Color.white;
    }

    public void setGreen() {
        ledRenderer.material.color = Color.green;
    }

    public void setRed() {
        ledRenderer.material.color = Color.red;
    }

}