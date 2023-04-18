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
    
    public void setWAN() {
        ledRenderer.material.color = Color.blue;
    }

    public void setERR() {
        ledRenderer.material.color = Color.red;
    }

    public void setIO() {
        ledRenderer.material.color = Color.yellow;
    }

    public void setDC() {
        ledRenderer.material.color = Color.green;
    }

}