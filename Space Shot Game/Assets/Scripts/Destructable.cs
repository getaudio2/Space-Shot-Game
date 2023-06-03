using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        Bullet bullet;
        bullet = collision.gameObject.GetComponent<Bullet>();
        Debug.Log(bullet);
        
        if (bullet != null)
        {
            Destroy(gameObject);
            Destroy(bullet.gameObject);
            Debug.Log("enemy hit");
        }
    }
}
