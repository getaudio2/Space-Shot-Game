using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 5;

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;
        pos.x -= moveSpeed * Time.fixedDeltaTime;
        if (pos.x < -10)
        {
            Destroy(gameObject);
        }

        transform.position = pos;    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Bullet")) {
            this.gameObject.SetActive(false);
        }
    }
}
