using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActivateGravity : MonoBehaviour
{
    void Start()
    {
        // le type du retour est du type du composant recherché
        Rigidbody rigidbody = GetComponent<Rigidbody>();    
        InputDetect keyDownDetector = GetComponent<InputDetect>();
        keyDownDetector.onInputDetected.AddListener(StartFalling);

         // alternativement:
         // GetComponent<InputDetect>().onInputDetected.AddListener(StartFalling);
    }

    void StartFalling()
    {
        Debug.Log("I am falling apart.");
        GetComponent<Rigidbody>().useGravity = true;
    }
}
