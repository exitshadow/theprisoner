using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputDetect : MonoBehaviour
{
    [HideInInspector]
    public UnityEvent onInputDetected;
    public UnityEvent onSneeze;
    int numberOfSneezes = 0;

    [System.Serializable] // pour rendre SneezeEvent lisible dans l’inspecteur
    public class SneezeEvent : UnityEvent<int> {}
    public SneezeEvent onManySneezes;

    // happens before Start()
    void Awake()
    {
        onInputDetected = new UnityEvent();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            // alternative à if(onInputDetected != null)
            Debug.Log("Yay");
            onInputDetected?.Invoke();

            onSneeze?.Invoke();

            numberOfSneezes++;
            onManySneezes.Invoke(numberOfSneezes);
        }
    }
}
