using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour {

    public void goToOverheadScene() {
          UnityEngine.SceneManagement.SceneManager.LoadScene("Overhead");
    }
     public void TruckScene()
     {
          UnityEngine.SceneManagement.SceneManager.LoadScene("Truck");
     }
}
