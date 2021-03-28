using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    public List<Transform> spawnPoints;
    public List<GameObject> enemyTypes;
    public List<GameObject> enemies;

    //public int enemySpawn;

    public void SpawnEnemy()
    {
        for (int i = 0; i < spawnPoints.Count; i++)
        {
            


            GameObject newEnemy = Instantiate<GameObject>(enemyTypes[0], spawnPoints[i].position, spawnPoints[i].rotation);
            enemies.Add(newEnemy);
        }
    }
  

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < spawnPoints.Count; i++)
        {
            if (Input.GetKeyUp("i"))
            {
                Instantiate<GameObject>(enemyTypes[i], spawnPoints[i].position, spawnPoints[i].rotation);
            }
        }

    }
}
