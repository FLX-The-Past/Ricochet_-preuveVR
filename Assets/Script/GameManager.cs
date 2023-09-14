using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using Random = Unity.Mathematics.Random;
using Range = System.Range;

public class GameManager : MonoBehaviour
{
    public float hightScore;
    public float currentPlayerScore;
    public bool gameStatut;
    public int totalEnnemies = 0;
    public List<GameObject> Wave;
    public float spawnNumber;
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    public void StarGame()
    {
        gameStatut = true;
    }

    public void EndGame()
    {
        gameStatut = false;
    }
}
