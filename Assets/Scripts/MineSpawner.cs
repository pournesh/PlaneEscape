using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineSpawner : MonoBehaviour
{
    public GameObject mine_prefab;
    public float min_x = -8.3f, max_x = 8.3f;
    public float spawnInterval = 3.5f;

    int mine_count;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ActivateMineSpawner", 2f);
    }

    // Update is called once per frame
    
    void ActivateMineSpawner()
    {
        StartCoroutine(SpawnMines());
        Invoke("ActivateMineSpawner",spawnInterval);
    }

    IEnumerator SpawnMines()
    {
         Vector3 temp_pos = transform.position;
         mine_count = Random.Range(2, 4);

         for (int i = 0; i < mine_count; i++)
            {
                temp_pos.x = Random.Range(min_x, max_x);
                temp_pos.y = Random.Range(15,6 );
                Instantiate(mine_prefab, temp_pos, Quaternion.identity);

            }
        yield return null;



    }
}
