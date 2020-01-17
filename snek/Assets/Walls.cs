using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D hitInfo) {
        Debug.Log("wall was hit, hitInfo " + hitInfo.name);
        if (hitInfo.name == "Player") {
            string wallName = transform.name;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
