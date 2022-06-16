using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSpawner : MonoBehaviour
{
    [SerializeField] private GameObject stonePrefab;
    [SerializeField] private float timeBetweenStonesSpawn;


    private void Start()
    {
        StartCoroutine(SpawnStone());
    }



    IEnumerator SpawnStone()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeBetweenStonesSpawn);
            var stone = Instantiate(stonePrefab);
            stone.transform.position = new Vector3(Random.Range(-3, 4), transform.position.y, 0);
        }
    }
}
