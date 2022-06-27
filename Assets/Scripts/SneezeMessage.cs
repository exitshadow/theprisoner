using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SneezeMessage : MonoBehaviour
{
    public void SneezeNoArgs()
    {
        Debug.Log("Sneeez!");
    }

    public void SneezeOneArg(int numberOfSneezes)
    {
        for (int i = 0; i < numberOfSneezes; i++)
        {
            Debug.Log($"I’m sneezing, time {i}.");
        }
    }

    public void HowManySneezes(int sneezeNb) {
        Debug.Log($"I’m sneezing {sneezeNb} time(s).");
    }
}
