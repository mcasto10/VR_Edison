using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DCFlash : MonoBehaviour
{
    Renderer ledRenderer;
    // Start is called before the first frame update
    void Start()
    {
        ledRenderer = GetComponent<Renderer>();
        StartCoroutine(Flash());
    }

    public void StopFlash() {
        StopAllCoroutines();
    }

    public void StartFlash() {
        StartCoroutine(Flash());
    }

    IEnumerator Flash() {
        while(true) {
            ledRenderer.material.color = Color.green;
            yield return new WaitForSeconds(0.2f);
            ledRenderer.material.color = Color.white;
            yield return new WaitForSeconds(1f);   
        }
    }
}
