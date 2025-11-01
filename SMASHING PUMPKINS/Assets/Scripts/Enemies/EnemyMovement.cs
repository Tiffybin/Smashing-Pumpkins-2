using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class EnemyMovement : MonoBehaviour
{
    public GameObject player;
    public float speed;

    private float distance;

    void Start()
    {

    }


    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
    }
}
