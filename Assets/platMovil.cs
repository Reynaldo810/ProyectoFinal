﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platMovil : MonoBehaviour
{
    public Transform pos1, pos2;
    public float speed;
    public Transform startPos;
    public bool empieza;

    Vector3 nextPos;

    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;
        speed = Random.Range(1f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (!empieza){
            if (Input.anyKeyDown){
                empieza = true;
            }
        }
        else {
        if(transform.position == pos1.position)
        {
            nextPos = pos2.position;
        }
        if(transform.position == pos2.position)
        {
            nextPos = pos1.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
        }
    }

    private void OnDrawGizmos() {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
}