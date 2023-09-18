using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public int patternNumber;
    public List<GameObject> wavesPattern;
    public Transform waverSpawner;
    public int numberOfWaves = 0;
    void Start()
    {
        patternNumber = Random.Range(0, 2);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(wavesPattern[patternNumber], waverSpawner.transform);
            Debug.Log(patternNumber);
        }
    }
}
