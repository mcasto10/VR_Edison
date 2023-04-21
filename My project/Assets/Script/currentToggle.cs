using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class currentToggle : MonoBehaviour
{
   public GameObject player; // gain access to the player's position

    private List<bool> boolList;

    void Update() {

       
        boolList = new List<bool> {false, false, false, false};
        // foreach(bool number in boolList) {
        //     Debug.Log(number);

        // }

        //    Debug.Log("--------------------------");

        Vector3 currentPosition = player.transform.position;

         Debug.Log(currentPosition.x);
        TeleportZone(currentPosition);
        ToggleBoolList();

    }

      public List<bool> TeleportZone(Vector3 currentPosition) {
          Vector3[] myVectors = new Vector3[4];
          // Scene 2
          myVectors[0] = new Vector3(2.962f, 0.63f, -3.27f);
          // Scene 3
          myVectors[1] = new Vector3(2.952f, 0.09f, -2.68f);
          // scene 5
          myVectors[2] = new Vector3(4.478518f, 2.26f, -20.00f);
          // sccene 9
          myVectors[3] = new Vector3(4.476227f, 0.09f, -2.65f);

          float epsilon = 0.0001f;

      for(int i = 0; i < myVectors.Length; i++){
            if(Mathf.Abs(myVectors[i].x - currentPosition.x) < epsilon) {
                for(int j = 0; j <= i; j++){
                    if(j == 0){
                        boolList.RemoveAt(0);
                        boolList.Insert(0, true);
                        // Debug.Log("Location 0");
                        setToggleScene2();

                    }
                    if(j == 1){
                        boolList.RemoveAt(1);
                        boolList.Insert(1, true);
                        //  Debug.Log("Location 1");
                        setToggleScene3();
                    }

                    if(j == 2){
                        boolList.RemoveAt(2);
                        boolList.Insert(2, true);
                        //  Debug.Log("Location 2");
                        setToggleScene5();
                    }
                    
                    if(j == 3){
                        boolList.RemoveAt(3);
                        boolList.Insert(3, true);
                        //  Debug.Log("Location 3");
                        setToggleScene9();
                    }
                }
              }
            }
      return boolList; 
    }

    public void ToggleBoolList(){

            for(int i = boolList.Count - 1; i >= 0; i--){
                if(boolList[i] == true) {
                    if(i == 3){
                        setToggleScene9();
                        setToggleScene5();
                        setToggleScene3();
                        setToggleScene2();
                    }
                    
                    if(i == 2){
                        unactiveToggleScene9();
                        setToggleScene5();
                        setToggleScene3();
                        setToggleScene2();
                        
                    }

                    if(i == 1){
                        unactiveToggleScene9();
                        unactiveToggleScene5();
                        setToggleScene3();
                        setToggleScene2();
                    }
                        
                    if(i == 0){
                        unactiveToggleScene9();
                        unactiveToggleScene5();
                        unactiveToggleScene3();
                        setToggleScene2();
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
        myToggle.isOn = true;  
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
