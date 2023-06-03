using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector2 direction = new Vector2(1,0);
    public float speed = 11;
    public GameObject explosionPrefab;
    private ControlPuntos controlPuntos;

    public Vector2 velocity;

    void Start() {
        controlPuntos = GameObject.Find("ControlPuntos").GetComponent<ControlPuntos>();
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Enemy")) {
            controlPuntos.UpdateScore(50);
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
