using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour {

    public void goToOverheadScene() {
          UnityEngine.SceneManagement.SceneManager.LoadScene("Overhead");
    }
    public void goToPoleMasterClose() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Pole Master Close-Up");
    }
     
     public void goToOverheadTesting(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Overhead testing stuff");
     }
}
