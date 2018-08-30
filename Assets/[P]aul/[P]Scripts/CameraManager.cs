using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public float mouseSensativity = 300;
    public CinemachineFreeLook freeLook;
    // Use this for initialization
    void Start()
    {
        if (freeLook == null)
        {
            Debug.LogError("No CameraManager assigned to Object: " + gameObject.name);
        }
    }
    void Update()
    {
        transform.rotation = Quaternion.AngleAxis(freeLook.m_XAxis.Value,Vector3.up);
    }
}
