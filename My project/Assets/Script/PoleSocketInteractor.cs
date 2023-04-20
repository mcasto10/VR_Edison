using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PoleSocketInteractor : XRSocketInteractor
{
    public openclose_smartnav clampControllerA;
    public openclose_smartnav clampControllerB;
    public openclose_smartnav clampControllerC;

    public override bool CanSelect(IXRSelectInteractable interactable)
    {
        return base.CanSelect(interactable) && (clampControllerA.isOpen || clampControllerB.isOpen || clampControllerC.isOpen);
    }
}