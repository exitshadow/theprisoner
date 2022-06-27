using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class FunnyMove : MonoBehaviour
{

    [Header("Physics on Rigibody inaction")]

    [Tooltip("Value of move on each time RigidBody stops")]
    public Vector3 speed = new Vector3(0f,.2f,0f);

    [Tooltip("Decreases value on each time RigidBody stops")]
    public Vector3 sillyFactor = new Vector3(0f, -.3f, 0f);
    
    [Range(0f,25f)] public float intensity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Rigidbody rb = GetComponent<Rigidbody>();

        if(rb.velocity == Vector3.zero) {
            
            transform.position += (speed + sillyFactor) * Time.deltaTime ;
        }
    }
}
