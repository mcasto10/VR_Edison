using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleController : MonoBehaviour
{
    public Toggle myToggle;

    public void ToggleValueChanged(Transform pos)
    {

          Vector3 currentPosition = pos.position;
          Debug.Log(currentPosition);

          Vector3[] myVectors = new Vector3[4];
          // Scene 2
          myVectors[0] = new Vector3(-1.329f,-1.10599995f,0.00899999961f);
          // Scene 3
          myVectors[1] = new Vector3(-0.600000024f,-5.80000019f,3.30999994f);
          // scene 5
          myVectors[2] = new Vector3(-0.518000007f,2.15499997f,2.14599991f);
          // sccene 9
          myVectors[3] = new Vector3(-3.23200011f,33.2799988f,-0.344999999f);

        // checking to see what scene the user is currently in, then updating all those that are valid
        for(int i = 0; i < myVectors.Length; i++){
            Debug.Log("Hello");
            //  Debug.Log(myVectors[i].ToString());
            if(myVectors[i] == pos.position){
                // Debug.Log(myVectors[i].ToString());
                for(int j = 0; j < i; j++){
                    if(j == 0){
                        Debug.Log("Location 1");
                        setToggleScene2();
                    }
                    if(j == 1){
                         Debug.Log("Location 2");
                        setToggleScene3();
                    }
                    if(j == 2){
                         Debug.Log("Location 3");
                        setToggleScene5();
                    }
                    if(j == 3){
                         Debug.Log("Location 4");
                        setToggleScene9();
                    }
                }

        }
              if(i == 0){
                    setToggleScene2();
                }
                if(i == 1){
                    setToggleScene3();
                }
                if(i == 2){
                    setToggleScene5();
                }
                if(i == 3){
                    setToggleScene9();
                }
        }

    }

    public void setToggleScene2(){
        if(myToggle.isOn = !myToggle.isOn){
             myToggle.isOn = true;
        }
        else {
            myToggle.isOn = !myToggle.isOn;
        }
    }

    public void setToggleScene3(){
          if(myToggle.isOn = !myToggle.isOn){
             myToggle.isOn = true;
        }
        else {
            myToggle.isOn = !myToggle.isOn;
        }
        
    }
    public void setToggleScene5(){
          if(myToggle.isOn = !myToggle.isOn){
             myToggle.isOn = true;
        }
        else {
            myToggle.isOn = !myToggle.isOn;
        }
    }

    public void setToggleScene9(){
          if(myToggle.isOn = !myToggle.isOn){
             myToggle.isOn = true;
        }
        else {
            myToggle.isOn = !myToggle.isOn;
        }
    }
}
