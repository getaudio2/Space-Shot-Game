using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    Gun[] guns;

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
        guns = transform.GetComponentsInChildren<Gun>();
    }

    // Update is called once per frame
    void Update()
    {
        moveUp = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
        moveDown = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S);
        moveLeft = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
        moveRight = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);
        slowDown = Input.GetKey(KeyCode.LeftShift);
        shoot = Input.GetKeyDown(KeyCode.Z);
        if (shoot)
        {
            shoot = false;
            foreach(Gun gun in guns)
            {
                gun.Shoot();
            }
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

        /*if (pos.x <= -5.3f)
        {
            pos.x = -5.3f;
        }

        if (pos.x >= 11.5f)
        {
            pos.x = 11.5f;
        }

        if (pos.y >= 5f)
        {
            pos.y = 5f;
        }

        if (pos.y <= -3.5f)
        {
            pos.y = -3.5f;
        }*/

        transform.position = pos;
    }
}
