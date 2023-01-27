using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Overhead_Button : MonoBehaviour {

    public void goToNextScene() {
        SceneManager.LoadScene("Overhead");
        
    }
}
