using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LazerAmmo : MonoBehaviour
{
    public int _bounce = 3;
    [SerializeField] private AudioSource ricochetSound;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (_bounce <= -1)
        {
            Destroy(gameObject);
        }

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Terrain"))
        {
            _bounce--;
            ricochetSound.Play();
        }
        
    }
    
}
