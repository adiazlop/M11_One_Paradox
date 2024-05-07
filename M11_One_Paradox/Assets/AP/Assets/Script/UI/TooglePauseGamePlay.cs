using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooglePauseGamePlay : MonoBehaviour
{
    public GameObject object1; // GameObject 1
    public GameObject object2; // GameObject 2

    // Este m�todo se llama cuando el GameObject adjunto se activa
    void OnEnable()
    {
        // Aseg�rate de que object1 est� activo y object2 est� desactivado cuando este script se active
        if (object1 != null)
        {
            object1.SetActive(true);
        }
        if (object2 != null)
        {
            object2.SetActive(false);
        }
    }

    // Este m�todo se llama cuando el GameObject adjunto se desactiva
    void OnDisable()
    {
        // Aseg�rate de que object2 est� activo y object1 est� desactivado cuando este script se desactive
        if (object2 != null)
        {
            object2.SetActive(true);
        }
        if (object1 != null)
        {
            object1.SetActive(false);
        }
    }
}
