using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangeColor : MonoBehaviour
{
    public Color color;
    public float chrono = 5f;
    private bool hasColorChanged = false;

    public UnityEvent whenColorChanges;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        chrono -= Time.deltaTime;
        if(chrono <= 0 &&!hasColorChanged) {
            Renderer renderer = GetComponent<Renderer>();
            // ça va aussi prendre MeshRenderer car il est enfant de Renderer
            // s’il n’y a pas d’objet parent présent, il prendra un des enfants
            // par ... polymorphisme!
            Material material = renderer.material;
            material.color = color;
            hasColorChanged = true;
            whenColorChanges.Invoke();
        }

        
    }
}
