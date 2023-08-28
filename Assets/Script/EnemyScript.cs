using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;

public class EnemyScript : MonoBehaviour
{
    public GameObject _explosionVfx;
    public GameObject _explosionSound;
    public Transform _player;
    void Start()
    {
        
    }
    
    
    void Update()
    {
       
    }

    void Destruction()
    {
        Instantiate(_explosionVfx, transform.position, transform.rotation);

        Instantiate(_explosionSound, transform.position, transform.rotation);

        transform.LookAt(_player,new Vector3(0f, 0f, 0f));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lazer"))
        {
            Destruction();
        }
    }
}
