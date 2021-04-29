using System.Collections;
using System.Collections.Generic;
using UnityEngine;


enum MoveDirection
{
    LEFT = -1,
    RIGHT = 1
}


public class Move : MonoBehaviour
{

    private MoveDirection direction = MoveDirection.RIGHT;

    private const int speed = 60;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I am started");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            ChangeDirection();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeDirection();
        }

        transform.RotateAround(Vector3.zero, Vector3.up, (int)direction * speed * Time.deltaTime);
    }

    void ChangeDirection()
    {
        this.direction = this.direction == MoveDirection.RIGHT
              ? MoveDirection.LEFT
              : MoveDirection.RIGHT;
    }
}
