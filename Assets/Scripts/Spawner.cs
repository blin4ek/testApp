using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private PoolManager pool;
    [SerializeField] private float frequency;
    private Coroutine spawn;
    private const float minY = -2.75f;
    private const float maxY = 2.75f;

    void Start()
    {
        GameOverEvent.RegHandler(StopSpawn);
    }

    public void StartSpawn()
    {
        spawn = StartCoroutine(Spawn()); 
    }

    private void StopSpawn()
    {
        StopCoroutine(spawn);
    }

    IEnumerator Spawn()
    {
        WaitForSeconds delay = new WaitForSeconds(frequency);
        GameObject temp;
        while (true)
        {
            yield return delay;
            temp = pool.GetFreeItem();
            temp.transform.position = new Vector3(transform.position.x, transform.position.y + Random.Range(minY, maxY));
            temp.SetActive(true);
            
        }
    }

}
