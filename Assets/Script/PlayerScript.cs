using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float rotationSpeed;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0f,-rotationSpeed,0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0f,rotationSpeed,0f);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(-rotationSpeed,0f,0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(rotationSpeed,0f,0f);
        }
    }
}
