// using UnityEngine;

// public class EnemySpawner : MonoBehaviour
// {
//     public GameObject enemy; 
//     public Transform spawnPoint;
//     public bool hasSpawned = false;

//     private float swarmInterval = 3.5f;

//     private void OnTriggerEnter(Collider other)
//     {
//         if (other.CompareTag("Enemy") && !hasSpawned)
//         {
//             Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
//             hasSpawned = true;
//         }
//     }
//     void Start()
//     {
//         StartCouroutine(spawnEnemy(swarmInterval, swarme))
//     }
//     private IEnumerator spawnEnemy(float interval, GameObject enemy)
//     {
//         yield return new WaitForSeconds(interval);
//         GameObject newEnemy = Instantiate(enemy, new Vector3(Random.range(-5f, 5), Random.Range(-6f, 6f), 0, Quaternion.identity));
//         StartCouroutine(spawnEnemy(interval, enemy));
//     }

// }