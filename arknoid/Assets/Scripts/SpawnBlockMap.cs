using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This particular script is responsible for spawning multiple Block.Prefabs
// It will position them according to the given pattern
// Currently the pattern is just a bunch of them in a row, created manually
// maybe later we'll be able to place them according to curves or mathematical figures
// that would be cool


public class SpawnBlockMap : MonoBehaviour
{
    public Camera m_OrthographicCamera;
    public float leftBorderPosition;
    public float rightBorderPosition;
    // Start is called before the first frame update
    void Start()
    {   
        // Initialize the camera and populate the other variables
        m_OrthographicCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        float height = 2f * m_OrthographicCamera.orthographicSize;
        float width = height * m_OrthographicCamera.aspect;
        float leftBorderPosition = -1f * (width / 2); 
        float rightBorderPosition = width / 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
