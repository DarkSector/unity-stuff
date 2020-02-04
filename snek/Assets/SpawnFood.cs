﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour {

    public GameObject FoodPrefab;
    public Transform BorderTop;
    public Transform BorderBottom;
    public Transform BorderLeft;
    public Transform BorderRight;
    // Start is called before the first frame update
    void Start()
    {

        Invoke("Spawn", 3);
        
    }

    void Spawn() {
        int x = (int)Random.Range(BorderLeft.position.x, 
        BorderRight.position.x);

        int y = (int)Random.Range(BorderBottom.position.y,
        BorderTop.position.y);

        Instantiate(FoodPrefab, 
        new Vector2(x, y), 
        Quaternion.identity);
    }

}
