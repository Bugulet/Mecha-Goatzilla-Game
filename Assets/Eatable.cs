using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eatable : MonoBehaviour
{
    // Start is called before the first frame update

    /// <summary>
    /// Represents the amount of mass added by the object to the animal when eaten
    /// </summary>
    public float Mass=1;

    /// <summary>
    /// Represents the minimum required weight for this to be edible
    /// </summary>
    public float MinimumWeight = 1;

    public float ShrinkSpeed = 0.05f;

    public bool IsDestroyed = false;

    private void Update()
    {
        if (IsDestroyed)
        {
            transform.localScale -= new Vector3(ShrinkSpeed,ShrinkSpeed,ShrinkSpeed);
        }

        if (transform.localScale.x <= 0)
        {

            Destroy(gameObject);
        }
    }

    /// <summary>
    /// Shrinks the object into oblivion
    /// </summary>
    public void StartShrink()
    {
        IsDestroyed = true;
    }

}
