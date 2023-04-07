using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class openclose_smartnav : MonoBehaviour
{
    public GameObject clamp;
    public float openAngle =-50f;
    public float closeAngle = -100f;

    private Quaternion clampOpen = Quaternion.identity;
    private Quaternion clampClose = Quaternion.identity;

    private XRGrabInteractable grabInteractable = null;
    private bool isOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.onActivate.AddListener(ToggleClamp);
        clampClose = Quaternion.Euler(closeAngle, 0f, 0f);
    }

    void ToggleClamp(XRBaseInteractor interactor)
    {
        isOpen = !isOpen;
        if (isOpen)
        {
            Quaternion targetRotation = Quaternion.Euler(openAngle, 0, 0);
            clamp.transform.localRotation = targetRotation;
        }
        else
        {
            clamp.transform.localRotation = clampClose;
        }

    }

}