﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    float speed;
    // Use this for initialization
    void Start()
    {
        speed = -8f;
    }

    // Update is called once per frame
    void Update()
    {

        //Get Bullet Current Position
        Vector2 position = transform.position;

        position = new Vector2(position.x, position.y + speed * Time.deltaTime);

        transform.position = position;

        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        if (transform.position.y > min.y)
        {
            Destroy(gameObject);
        }


    }
}
