using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public Bullet bullet;
    public AudioSource shotSound;

    float moveSpeed = 10;

    bool moveUp;
    bool moveDown;
    bool moveLeft;
    bool moveRight;
    bool slowDown;

    bool shoot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveUp = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
        moveDown = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S);
        moveLeft = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
        moveRight = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);
        slowDown = Input.GetKey(KeyCode.LeftShift);
        if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Return))
        {
            Instantiate(this.bullet, transform.position, Quaternion.identity);
            shotSound.Play();
        }
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        float moveAmount = moveSpeed * Time.fixedDeltaTime;
        if (slowDown)
        {
            moveAmount /= 2;
        }
        Vector2 move = Vector2.zero;

        if (moveUp)
        {
            move.y += moveAmount;
        }

        if (moveDown)
        {
            move.y -= moveAmount;
        }

        if (moveLeft)
        {
            move.x -= moveAmount;
        }

        if (moveRight)
        {
            move.x += moveAmount;
        }

        float moveMagnitude = Mathf.Sqrt(move.x * move.x + move.y * move.y);
        if (moveMagnitude > moveAmount)
        {
            float ratio = moveAmount / moveMagnitude;
            move *= ratio;
        }

        pos += move;

        if (pos.x <= -8.3f)
        {
            pos.x = -8.3f;
        }

        if (pos.x >= 8.8f)
        {
            pos.x = 8.8f;
        }

        if (pos.y >= 4.8f)
        {
            pos.y = 4.8f;
        }

        if (pos.y <= -4.8f)
        {
            pos.y = -4.8f;
        }

        transform.position = pos;
    }
}
