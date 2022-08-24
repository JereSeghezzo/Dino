using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Obstacle;

    public void SpawnObstacle()
    {
       Instantiate(Obstacle, transform.position, Quaternion.identity);
    }
}
