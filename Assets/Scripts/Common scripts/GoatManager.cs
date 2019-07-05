using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoatManager : MonoBehaviour
{

    public Transform goat;
    public Camera mainCamera;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GrowSheep(float growth)
    {
        goat.localScale += Vector3.one*growth;
        mainCamera.GetComponent<ThirdPersonCamera>().RefreshOffset(goat.localScale.x);
    }
}
