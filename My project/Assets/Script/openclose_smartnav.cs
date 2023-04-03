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

    // Start is called before the first frame update
    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.onActivate.AddListener(OnGrab);
        grabInteractable.onDeactivate.AddListener(OnRelease);

        clampClose = Quaternion.Euler(closeAngle, 0f, 0f);
    }

    void OnGrab(XRBaseInteractor interactor)
    {
        Quaternion targetRotation = Quaternion.Euler(openAngle, 0 , 0);
        clamp.transform.localRotation = targetRotation;
    }

    void OnRelease(XRBaseInteractor interactor)
    {
        clamp.transform.localRotation = clampClose;
    }
}