using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public Vector2 direction = new Vector2(1,0);
    public float speed = 11;

    public Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        velocity = direction * speed;
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        pos += velocity * Time.fixedDeltaTime;

        if (pos.x >= 10f)
        {
            Destroy(gameObject);
        }

        transform.position = pos;
    }
}
