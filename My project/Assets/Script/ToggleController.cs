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

          Vector3[] myVectors = new Vector3[4];
          // Scene 2
          myVectors[0] = new Vector3(2.96f, 0.63f, -3.27f);
          // Scene 3
          myVectors[1] = new Vector3(4.48f, 0.09f, -2.68f);
          // scene 5
          myVectors[2] = new Vector3(2.95f, 2.26f, -20.00f);
          // sccene 9
          myVectors[3] = new Vector3(4.48f, 0.09f, -2.65f);
       
        Debug.Log(myToggle.ToString());
           
        // checking to see what scene the user is currently in, then updating all those that are valid
        for(int i = 0; i < myVectors.Length; i++){
            Debug.Log(currentPosition + " current position");
            Debug.Log(myVectors[i].ToString() + " loop position " + i );
            // Debug.Log(new Vector3((float)currentPosition.x, (float)currentPosition.y, (float)currentPosition.z) == myVectors[i]);
            // Debug.Log(myVectors[i] == currentPosition);
            // Debug.Log(myVectors[i].Equals(currentPosition));


            // if (new Vector3((float)currentPosition.x, (float)currentPosition.y, (float)currentPosition.z) == myVectors[i] ) {
            if(myVectors[i] == currentPosition){
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
            //   if(i == 0){
            //         setToggleScene2();
            //     }
            //     if(i == 1){
            //         setToggleScene3();
            //     }
            //     if(i == 2){
            //         setToggleScene5();
            //     }
            //     if(i == 3){
            //         setToggleScene9();
            //     }
        }

    }

    public void setToggleScene2(){
        Debug.Log("Enter 2");
        if(myToggle.isOn = !myToggle.isOn){
             myToggle.isOn = true;
        }
        else {
            myToggle.isOn = !myToggle.isOn;
        }
    }

    public void setToggleScene3(){
         Debug.Log("Enter 3");
          if(myToggle.isOn = !myToggle.isOn){
             myToggle.isOn = true;
        }
        else {
            myToggle.isOn = !myToggle.isOn;
        }
        
    }
    public void setToggleScene5(){
         Debug.Log("Enter 5");
          if(myToggle.isOn = !myToggle.isOn){
             myToggle.isOn = true;
        }
        else {
            myToggle.isOn = !myToggle.isOn;
        }
    }

    public void setToggleScene9(){
         Debug.Log("Enter 9");
          if(myToggle.isOn = !myToggle.isOn){
             myToggle.isOn = true;
        }
        else {
            myToggle.isOn = !myToggle.isOn;
        }
    }
}
