using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject goat;
    public Text score;

    void Start()
    {
        goat = GameObject.Find("Goat");    
    }

    // Update is called once per frame
    void Update()
    {
        if (goat != null)
        {
            score.text = goat.transform.localScale.magnitude.ToString("0");
        }
    }
}
