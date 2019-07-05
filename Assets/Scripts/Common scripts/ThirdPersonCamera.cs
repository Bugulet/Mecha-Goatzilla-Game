using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private  Transform _target;

    private Vector3 _offset;
    private Vector3 _updatedOffset;

    void Start()
    {
        if (_target == null)
        {
            Debug.Log("REFERENCE FOR CAMERA TARGET NOT SET");
        }
        else
        {
            _offset = transform.position - _target.position;
            _updatedOffset = _offset;
        }

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = _target.position + _updatedOffset;
    }

    public void RefreshOffset(float scale)
    {
        _updatedOffset = _offset * scale;
    }
}
