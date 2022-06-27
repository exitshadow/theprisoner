using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoDown : MonoBehaviour
{
    [Range(0,10)] public float downFactor = 1f;
    float direction = -1f;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (target.transform.position.y >= transform.position.y)
        {
            direction = 1f;

        } else if (transform.position.y >= 4f) {

            direction = -1f;
        }

        Vector3 currentPosition = new Vector3(0, downFactor * direction, 0);
        transform.position += currentPosition * Time.deltaTime;
    }
}
