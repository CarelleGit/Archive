using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMotion : MonoBehaviour
{
    
    public CharacterController controller;
    //normalized direction

    public float speed;



    // Use this for initialization
    void Start()
    {
        if (controller == null)
        {
            Debug.LogError("No CharacterController assigned to Object: " + gameObject.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 normalDir = Vector3.zero;



        if (Input.anyKey)
        {
            if (Input.GetKey(KeyCode.W))
            {
                normalDir += transform.forward;
            }

            if (Input.GetKey(KeyCode.A))
            {
                normalDir -= transform.right;
            }

            if (Input.GetKey(KeyCode.S))
            {
                normalDir -= transform.forward;
            }

            if (Input.GetKey(KeyCode.D))
            {
                normalDir += transform.right;
            }

            if (Input.GetKey(KeyCode.LeftShift))
            {
                controller.Move(normalDir.normalized * (speed * 2) * Time.deltaTime);
            }
            else
            {
                controller.Move(normalDir.normalized * (speed * Time.deltaTime));
            }
        }
    }
}
