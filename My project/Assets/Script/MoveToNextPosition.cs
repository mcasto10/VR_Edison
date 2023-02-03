using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // for button use

public class MoveToNextPosition : MonoBehaviour
{
     public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
          //button.onClick.AddListener(Teleport);
    }


    public void Teleport(GameObject NextLocation)
    {
          Transform pos = NextLocation.transform;
          //transform.position = new Vector3(38.5F, -6.824F, -17.4F);
          
          player.transform.position = pos.position;
     }

}
