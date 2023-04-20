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
        StartCoroutine(PairingMode());

    }


    public void StopPairingMode() {
        StopAllCoroutines();
    }

    IEnumerator PairingMode() {
        while(true) {
            ledRenderer.material.color = Color.yellow;
            yield return new WaitForSeconds(0.2f);
            ledRenderer.material.color = Color.white;
            yield return new WaitForSeconds(0.2f);
            ledRenderer.material.color = Color.yellow;
            yield return new WaitForSeconds(0.2f);
            ledRenderer.material.color = Color.white;
            yield return new WaitForSeconds(1f);
        }
    }

}