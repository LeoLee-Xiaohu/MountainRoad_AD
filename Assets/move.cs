using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class move : MonoBehaviour

{

    private Transform son;

    public bool moveToLeft = true;

    private float speed = 2;

    private void Start()

    {

        son = this.transform;

    }

    private void Update()

    {

        Move();

    }

    private void Move()

    {

        if (son.position.x <= -3 && moveToLeft)

        {

            moveToLeft = false;

        }

        else if (son.position.x >= 3 && !moveToLeft)

            moveToLeft = true;

        son.position += (moveToLeft ? Vector3.left : Vector3.right) * Time.deltaTime * speed;

    }

}
