using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using TMPro;

public class TriggerInputDetector : MonoBehaviour
{
    private InputData _inputData;

    private void Start()
    {
        _inputData = GetComponent<InputData>();
    }
    // Update is called once per frame
    void Update()
    {
        // if (_inputData._leftController.TryGetFeatureValue(CommonUsages.triggerButton, out float triggerValue))
        // {
        //     //_leftMaxScore = theFloat;
        //     leftScoreDisplay.text = triggerValue.ToString();
        //     Debug.Log("triggerValue: " + triggerValue);
        // }
        Debug.Log("Hi");
        if (_inputData._rightController.TryGetFeatureValue(CommonUsages.triggerButton, out bool triggerButton))
        {
            if(triggerButton) {
                GameObject.FindGameObjectWithTag("WAN").GetComponent<WanLed>().enabled = true;
            }
            Debug.Log("Trigger button: " + triggerButton);
        }
    }
}