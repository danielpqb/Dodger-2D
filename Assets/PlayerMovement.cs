using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float velocity = 10;
    public bool playerIsAlive = true;

    // Update is called once per frame
    void Update()
    {
        if (playerIsAlive) {
            if (myRigidbody.position.y < 4.6)
            {
                //Mobile movement
                if (Input.touchCount > 0)
                {
                    Touch touch = Input.GetTouch(0);
                    if (touch.position.y > touch.rawPosition.y)
                    {
                        Move(Vector2.up);
                    }
                }

                //PC movement
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    Move(Vector2.up);
                }
            }

            if (myRigidbody.position.y > -4.5)
            {
                //Mobile movement
                if (Input.touchCount > 0)
                {
                    Touch touch = Input.GetTouch(0);
                    if (touch.position.y < touch.rawPosition.y)
                    {
                        Move(Vector2.down);
                    }
                }

                //PC movement
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    Move(Vector2.down);
                }
            }
        }
    }

    void Move(Vector2 vector)
    {
        myRigidbody.position += vector * velocity / 100;
    }
}
