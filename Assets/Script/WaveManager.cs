using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public int patternNumber;
    public List<GameObject> wavesPattern;
    public Transform waverSpawner;
    void Start()
    {
        patternNumber = Random.Range(0, 1);

        //Instantiate(wavesPattern, waverSpawner.position, waverSpawner.rotation);
    }

    
    void Update()
    {
        
    }
}
