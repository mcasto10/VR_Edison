using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class poleRelease : MonoBehaviour
{
    public GameObject clamp;
    public float closeAngle = -100f;

    private Quaternion clampClose = Quaternion.identity;

    private XRSocketInteractor poleSocket;

    // Start is called before the first frame update
    void OnEnable()
    {
        //grabInteractable = GetComponent<XRGrabInteractable>();
        poleSocket.selectEntered.AddListener(CloseClamp);
        clampClose = Quaternion.Euler(closeAngle, 0f, 0f);
    }

    void CloseClamp(SelectEnterEventArgs args)
    {
        clamp.transform.localRotation = clampClose;
    }
}

