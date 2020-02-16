﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{   
    public Rigidbody2D rb2d;
    public float speed = 20.0f;
    KeyCode moveLeft = KeyCode.LeftArrow;
    KeyCode moveRight = KeyCode.RightArrow;
    // Start is called before the first frame update
    private float leftBorderPosition;
    private float rightBorderPosition;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        GameObject myCamera = GameObject.Find("Main Camera");
        Debug.Log("game object camera: " + myCamera.tag);

        SpawnBlockMap spawnBlockMap = myCamera.GetComponent<SpawnBlockMap>();

        Dictionary<string, float> borderPositions =  spawnBlockMap.getLeftBorderPositions();

        float leftBorderPosition = borderPositions["left"];
        float rightBorderPosition = borderPositions["right"];

        Debug.Log("leftBorderPosition: " +  leftBorderPosition);
        Debug.Log("rightBorderPosition: " + rightBorderPosition);

    }

    // Update is called once per frame
    void Update()
    {   
        var pos = rb2d.position;
        if (Input.GetKey(moveLeft))
		{
			pos.x -= 0.5f;
		}
		else if (Input.GetKey(moveRight))

		{
			pos.x += 0.5f;
		}
        rb2d.position = pos;

    }


}
