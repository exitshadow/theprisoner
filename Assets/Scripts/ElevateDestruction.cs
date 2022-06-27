using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevateDestruction : BetterElevator
{
    [Tooltip("Number of alternations before the object self-destroys")]
    public int alternationsToDestruction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
        if (nbOfAlternations == alternationsToDestruction)
        {
            Destroy(gameObject);
        }
    }
}
