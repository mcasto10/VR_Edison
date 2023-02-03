using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // for button use

public class MoveToNextPosition : MonoBehaviour
{
     public GameObject player;

    public void Teleport(GameObject NextLocation)
    {
          Transform pos = NextLocation.transform;
          player.transform.position = pos.position;
     }

}
