using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IOPairingMode : MonoBehaviour
{
    Renderer ledRenderer;
    // Start is called before the first frame update
    void Start()
    {
        ledRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        ledRenderer.material.color = Color.Lerp(Color.white, Color.yellow, Mathf.PingPong(Time.time * 4, 1));
    }
}
