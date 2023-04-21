using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testing_input : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          if (Input.GetButtonUp("XRI_Right_GripButton"))
          {
               Debug.Log("right grip released");
          }
          else
               Debug.Log("nothing");
          Debug.Log("updating");
     }
}
