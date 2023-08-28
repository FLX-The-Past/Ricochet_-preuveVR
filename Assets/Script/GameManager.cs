using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float hightScore;
    public float currentPlayerScore;
    public bool gameStatut;
    public GameObject _ennemi;
    public float daRandomNumber;
    public int totalEnnemies = 0;
    public List<GameObject> _spawns = new List<GameObject>();
    void Start()
    {
    }
    
    void Update()
    {
        //daRandomNumber = Random.Range(0f, 7f);
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
