using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanLed : MonoBehaviour
{
    Renderer ledRenderer;
    // Start is called before the first frame update
    void Start()
    {
        ledRenderer = GetComponent<Renderer>();
        ledRenderer.material.color = Color.blue;
    }

}
