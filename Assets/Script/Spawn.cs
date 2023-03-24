using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform alo;
    public GameObject prefab;
    public List<GameObject> spawned;

    protected float spawnTimer = 0f;
    protected float spawnDelay = 1f;

    private void Update()
    {
        this.SpawnEnemy();
        this.CheckDead();
    }

    protected void SpawnEnemy()
    {
        if (this.spawned.Count >= 5) return;

        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < this.spawnDelay) return;
        this.spawnTimer = 0f;
        Vector3 pos = new Vector3(0, Random.Range(-2, 3), 0);
        GameObject emeny = Instantiate(this.prefab, alo.position + pos, alo.rotation);
        spawned.Add(emeny);
    }

    protected virtual void CheckDead()
    {
        GameObject minion;
        for (int i = 0; i < this.spawned.Count; i++)
        {
            minion = this.spawned[i];
            if (minion == null) this.spawned.RemoveAt(i);
        }
    }
}
