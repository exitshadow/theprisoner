using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterElevator : Elevator
{
    public float timeReverse = 2f;
    private float chrono = 0f;
    protected int nbOfAlternations = 0;

    override protected void Update()
    {
        base.Update();
        chrono += Time.deltaTime;

        //Debug.Log(chrono);
        // ceci va générer des FICHIERS log avec tous les chronos
        // c’est très pratique mais lourd

        if (chrono >= timeReverse)
        {
            switch (actualDirection)
            {
                    case Direction.up :
                        actualDirection = Direction.down;
                        break;
                    case Direction.down :
                        actualDirection = Direction.up;
                        break;
                    case Direction.right :
                        actualDirection = Direction.left;
                        break;
                    case Direction.left :
                        actualDirection = Direction.right;
                        break;
            }
            nbOfAlternations++;

            chrono = 0f;
                
        }
    }
}
