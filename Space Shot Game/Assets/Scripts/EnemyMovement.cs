using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 5;

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("hit detected");
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
}
