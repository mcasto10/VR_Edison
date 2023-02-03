using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // for button use

public class MoveToNextPosition : MonoBehaviour
{
     public Button button;

    // Start is called before the first frame update
    void Start()
    {
          button.onClick.AddListener(Teleport);
    }


    public void Teleport()
    {
        transform.position = new Vector3(38.5F, -6.824F, -17.4F);
    }

}
