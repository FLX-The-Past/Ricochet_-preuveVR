using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.XR.Interaction.Toolkit;

public class pistolShotV2 : MonoBehaviour
{
    public AudioSource fireSound;
    public GameObject _canon;
    public VisualEffect FireSFX;
    public GameObject _bullet;
    public float FireForce;
    public float destroyTime = 2f;
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(Shoot);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void Shoot(ActivateEventArgs arg)
    {
        GameObject spawnedBullet = Instantiate(_bullet);
        spawnedBullet.transform.position = _canon.transform.position;
        spawnedBullet.GetComponent<Rigidbody>().velocity = _canon.transform.forward * FireForce;
        fireSound.Play();
        FireSFX.Play();
        Destroy(spawnedBullet, destroyTime);
    }
}
