﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// objective of this script is to initialize the block
// create a random color
public class BlockInitialize : MonoBehaviour
{

    public GameObject Block;
    // Start is called before the first frame update
    void Start()
    {
        Block.GetComponent<SpriteRenderer>().color = Random.ColorHSV();
    }
}
