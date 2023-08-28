using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.XR.Interaction.Toolkit;

public class GunShot : MonoBehaviour
{
    public GameObject lazerAmmo;
    public float _force;
    public LazerAmmo _cooldonw;
    [SerializeField] private AudioSource _shootSound;
    [SerializeField] private VisualEffect shootVFX;
    public bool _shot = false;
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(Shoot);
    }

    
    void Update()
    {
        
    }

    void Shoot(ActivateEventArgs arg)
    {
        if (_shot == true)
        {
            GameObject _lazer = Instantiate(lazerAmmo, transform.position, transform.rotation);
            Rigidbody lazerRb =  _lazer.GetComponent<Rigidbody>();
            lazerRb.AddForce(transform.forward * _force, ForceMode.VelocityChange);
            _shootSound.Play();
            shootVFX.Play();
            _shot = false;
        }
    }
}
