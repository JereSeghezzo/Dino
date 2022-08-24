using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Spawners;

    [SerializeField] float SpawnCDMax;
    [SerializeField] float SpawnCDMin;
    GameObject SpawnPoint;
    float CD;

    void FixedUpdate()
    {
        SpawnTimer();
    }

    void SpawnTimer()
    {
        CD -= Time.deltaTime;

        if (CD <= 0f)
        {
            ChooseSpawn();
            CD = Random.Range(SpawnCDMin, SpawnCDMax);
        }
    }

    void ChooseSpawn()
    {
        SpawnPoint = Spawners[Random.Range(0, Spawners.Length)];
        SpawnPoint.GetComponent<Spawn>().SpawnObstacle();
    }
}
