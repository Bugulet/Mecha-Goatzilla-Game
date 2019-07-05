using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatObject : MonoBehaviour
{
    public GameObject Goat;

    

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("edible") && other.GetComponent<Eatable>().IsDestroyed == false)
        {
                Goat.GetComponent<GoatManager>().GrowSheep(other.GetComponent<Eatable>().Mass);
                other.GetComponent<Eatable>().StartShrink();
        }
    }
}
