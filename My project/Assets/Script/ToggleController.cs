using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ToggleController : MonoBehaviour
{
   public GameObject player; // gain access to the player's position

    // private List<bool> boolList;

    void Update() {
        // boolList = new List<bool> {false, false, false, false};

        Vector3 currentPosition = player.transform.position;

        Debug.Log(currentPosition.x);

        TeleportZone(currentPosition);

    }

      public void TeleportZone(Vector3 currentPosition) {
          Vector3[] myVectors = new Vector3[6];

          // Scene 2
          myVectors[0] = new Vector3(4.419543f, 0.63f, -3.27f);
          // Scene 3
          myVectors[1] = new Vector3(3.06f, 0.09f, -2.68f);
          // scene 5
          myVectors[2] = new Vector3(4.477241f, 2.26f, -20.00f);
          // sccene 9
          myVectors[3] = new Vector3(4.477057f, 0.09f, -2.65f);

          myVectors[4] = new Vector3(0f, 0f, 0f);

          myVectors[5] = new Vector3(3.086f, 0f, 0f);

     

          float epsilon = 0.00001f;

      for(int i = 0; i < myVectors.Length; i++){
            if(Mathf.Abs(myVectors[i].x - currentPosition.x) < epsilon) {
                    if(i == 0){
                        Debug.Log("Scene 1");
                        unactiveToggleScene9();
                        unactiveToggleScene5();
                        unactiveToggleScene3();
                        setToggleScene2();

                    }
                    if(i == 1){
                         Debug.Log("Scene 2");
                        unactiveToggleScene9();
                        unactiveToggleScene5();
                        setToggleScene3();
                        setToggleScene2();
                 
                    }

                    if(i == 2){
                        unactiveToggleScene9();
                        setToggleScene5();
                        setToggleScene3();
                        setToggleScene2();
                    }

                      if(i == 3){
                        setToggleScene9();
                        setToggleScene5();
                        setToggleScene3();
                        setToggleScene2();
                      }
                    
                    if(i == 4 || i == 5){
                        unactiveToggleScene9();
                        unactiveToggleScene5();
                        unactiveToggleScene3();
                        unactiveToggleScene2();
                    }

                }
            }
    }

    public void setToggleScene2(){
        Toggle myToggle = GameObject.FindWithTag("SetSafetyTag").GetComponent<Toggle>();
        myToggle.isOn = true;
    }

    public void unactiveToggleScene2(){
        Toggle myToggle = GameObject.FindWithTag("SetSafetyTag").GetComponent<Toggle>();
        myToggle.isOn = false;
    }

    public void setToggleScene3(){
        Toggle myToggle = GameObject.FindWithTag("SetPoleMaster").GetComponent<Toggle>();
        myToggle.isOn = true;
    }

    public void unactiveToggleScene3(){
        Toggle myToggle = GameObject.FindWithTag("SetPoleMaster").GetComponent<Toggle>();
        myToggle.isOn = false;  
    }

     public void setToggleScene5(){
        Toggle myToggle = GameObject.FindWithTag("SetSmartNav").GetComponent<Toggle>();
        myToggle.isOn = true;
    }

    public void unactiveToggleScene5(){
        Toggle myToggle = GameObject.FindWithTag("SetSmartNav").GetComponent<Toggle>();
        myToggle.isOn = false;
    }

    public void setToggleScene9(){
        Toggle myToggle = GameObject.FindWithTag("SetCheckSmartNav").GetComponent<Toggle>();
        myToggle.isOn = true;
    }
    public void unactiveToggleScene9(){
       Toggle myToggle = GameObject.FindWithTag("SetCheckSmartNav").GetComponent<Toggle>();
       myToggle.isOn = false;
    }
}
