using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy; 
    public Transform spawnPoint; 
    public bool hasSpawned = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") && !hasSpawned)
        {
            Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
            hasSpawned = true; 
        }
    }
}