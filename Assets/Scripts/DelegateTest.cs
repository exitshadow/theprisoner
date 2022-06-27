using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateTest : MonoBehaviour
{
    delegate void ASimpleFunction();

    ASimpleFunction attack;

    void Start()
    {
        attack = Offends;
        // no arguments, what is passed is the reference
        // the function
        attack += PlaysOffendedSound;
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            attack();
        }
    }

    void Offends()
    {
        Debug.Log("I’m saying something very offensive. You loose 2HP.");
    }

    void PlaysOffendedSound()
    {
        Debug.Log("Oh, noooooes! How DARE you");
    }
}
