using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; // pour appeler les évenements tranquilou

public class anything : MonoBehaviour
{
    // exo
    // définir une vitesse
    // faire le scale qui augmente la taille du truc au cours du temps
    // la vitesse doit être comprise entre 0 et 20

    [Range(0,20)] public float speed = 5f;
    public float maxScale = 15f;
    private bool isScaleMax = false;

    public UnityEvent whenScaleMax;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 maximum = new Vector3(maxScale, maxScale, maxScale);
        if (transform.localScale != maximum)
        {
            Vector3 currentScale = new Vector3(1, 1, 1) * speed ;
            transform.localScale += currentScale * Time.deltaTime;
            transform.localScale = Vector3.Min(transform.localScale, maximum);
        } else if (!isScaleMax)
        {
            isScaleMax = true;
            // place our event here
            // avec ce système de condition fausse pour entrer et
            // assignation à vrai automatiquement dedans, cela assure que
            // les instructions à suivre ne se déclenchen qu’une seule fois
            whenScaleMax.Invoke();


        }

        // Mathf.Min(float, float)//renvoie le plus petit des objets
        // Vector3.Min() pareil mais avec un V3
    }
}
