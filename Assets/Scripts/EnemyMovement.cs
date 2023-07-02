using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float enemyMoveSpeed = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * enemyMoveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Boundary")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
            enemyMoveSpeed *= -1;
        }
        
    }
}
