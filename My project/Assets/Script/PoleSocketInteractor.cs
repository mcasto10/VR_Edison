using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PoleSocketInteractor : XRSocketInteractor
{
    public openclose_smartnav clampController;

    public override bool CanSelect(IXRSelectInteractable interactable)
    {
        return base.CanSelect(interactable) && clampController.isOpen;
    }
}