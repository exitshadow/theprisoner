using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunnyRotate : MonoBehaviour
{
    public Vector3 speed = new Vector3(.1f,.2f,.05f);

    public GameObject target;
    public float triggerDistance = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null || Vector3.Distance(transform.position, target.transform.position) < triggerDistance)
        {

            Rigidbody rb = GetComponent<Rigidbody>();

            if(rb.velocity == Vector3.zero) {
                
                Vector3 rotation = transform.rotation.eulerAngles;
                rotation += speed;
                transform.rotation = Quaternion.Euler(rotation);
            }
        }


    }
}
