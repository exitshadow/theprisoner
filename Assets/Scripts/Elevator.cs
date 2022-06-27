using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : anything
{

    public void ChangeSpeed(float speed) {
        this.speed = speed;
    }

    //public float speed = 5f;
    public bool ElevatorOn = false;
    public enum Direction
    {
        up, down, left, right
    }

    public Direction actualDirection = Direction.up;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    virtual protected void Update()
    {

        if (!ElevatorOn) return;

        // void Active() {
        //     ElevatorOn = true;
        // }

        Vector3 movement = new Vector3();
        // alternativement, on peut écrire Vector3.zero;

        switch (actualDirection)
        {
            case Direction.up : movement = Vector3.up; break;
            case Direction.down : movement = Vector3.down; break;
            // la classe Vector possède des variables statiques
            // qui représentent les directions en question
            // on n’a donc pas besoin de réecrire les directions
            // en (0,1,0) pour up par exemple;
            case Direction.right : movement = Vector3.right; break;
            case Direction.left : movement = Vector3.left; break;
        }
        
        transform.position += movement * Time.deltaTime;
    }

}
