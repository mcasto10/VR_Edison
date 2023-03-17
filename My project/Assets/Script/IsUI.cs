using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class IsUI : MonoBehaviour
{
     //public XRRayInteractor leftUIRay;
     public XRRayInteractor rightUIRay;
     public GameObject rightRay;



    // Update is called once per frame
    void Update()
    {
          //check if ray is hovering over anything 
          bool isRightRayHovering = rightUIRay.TryGetHitInfo(out Vector3 rightPos, out Vector3 rightNormal, out int rightNumber, out bool rightValid);
          //rightRay.GetComponent<LineRenderer>().!isRightRayHovering;
          //List<IXRHoverInteractable> targets = rightUIRay.interactablesHovered;
          //Debug.Log(targets);
          //targets[0].
          //rightUIRay.GetHoverTargets(targets);
          //bool isRightRayHovering = rightUIRay.TryGetHitInfo(out Vector3 rightPos, out Vector3 rightNormal, out int rightNumber, out bool rightValid);


     }
}
