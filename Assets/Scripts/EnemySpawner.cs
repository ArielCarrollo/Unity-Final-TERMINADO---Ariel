using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject EnemySpecial;
    public GameManager Gmc;
    public int AppearTime = 6;
    public int AppearTimeS = 7;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("CreateEnemy", 1);
        Invoke("CreateSpecialEnemy", 3);
    }
    void Update()
    {
        if (Gmc.Times <= 320)
        {
            AppearTime = 5;
            AppearTimeS = 6;
        }
        if (Gmc.Times <= 280)
        {
            AppearTime = 4;
            AppearTimeS = 5;
        }
        if (Gmc.Times <= 220)
        {
            AppearTime = 3;
            AppearTimeS = 4;
        }
        if (Gmc.Times <= 180)
        {
            AppearTime = 2;
            AppearTimeS = 3;
        }
        if (Gmc.Times <= 60)
        {
            AppearTime = 1;
            AppearTimeS = 2;
        }
    }
    void CreateEnemy()
    {
        CreateEnemy(Enemy, AppearTime);
    }
    void CreateEnemy(GameObject enemyPrefab, int appearTime)
    {
        GameObject enemy = Instantiate(enemyPrefab, new Vector3(10f, Random.Range(3.50f, -4.5f), 0), transform.rotation);
        enemy.GetComponent<EnemyController>().SetGameManager(Gmc);
        Invoke("CreateEnemy", appearTime);
    }
    void CreateSpecialEnemy()
    {
        CreateSpecialEnemy(EnemySpecial, AppearTimeS);
    }
    void CreateSpecialEnemy(GameObject specialEnemyPrefab, int appearTimeS)
    {
        GameObject enemy2 = Instantiate(specialEnemyPrefab, new Vector3(12f, Random.Range(3.50f, -4.5f), 0), transform.rotation);
        enemy2.GetComponent<EnemySpecialControl>().SetGameManager(Gmc);
        Invoke("CreateSpecialEnemy", appearTimeS);
    }
}
