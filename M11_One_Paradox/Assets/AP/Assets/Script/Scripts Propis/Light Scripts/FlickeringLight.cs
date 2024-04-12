using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour
//Amb aquest script creem l'efecte de llum que parpalleja. 
{
    public bool isFlickering = false;
    public float timeDelay;
    
    //Utilitzar aquestes variables si volem definir a l'inspector el valors minims del time delay
    //[Serialized Field] float minTime;
    //[Serialized Field] float maxTime;   
   

    // Update is called once per frame
    void Update()
    {
        if (isFlickering==false)
        {
            StartCoroutine(FlickeringLights());
        }
        
    }

    IEnumerator FlickeringLights()
    {
        isFlickering = true; 
        this.gameObject.GetComponent<Light>().enabled = false;
        //Modificar aquests valors per modificar l'efecte
        timeDelay = Random.Range(0.01f, 0.2f);
        yield return new WaitForSeconds(timeDelay);
        this.gameObject.GetComponent<Light>().enabled = true;
        //Modificar aquests valors per modificar quan de temps pasa per fer l'efecte
        timeDelay = Random.Range(1f, 5f);
        yield return new WaitForSeconds(timeDelay);
        isFlickering = false; 


    }
}
