using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skybox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float speed;
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation",Time.time*speed);
    }
}
