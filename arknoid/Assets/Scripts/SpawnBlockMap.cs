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
    public GameObject BlockPrefab;

    public int blockRows; // number of rows of blocks


    void Start()
    {
 

        SpawnBlocks();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBlocks() {

        // block size
        float blockSizeX = BlockPrefab.transform.GetComponent<SpriteRenderer>().bounds.size.x;
        float blockSizeY = BlockPrefab.transform.GetComponent<SpriteRenderer>().bounds.size.y;
        
        float blockSizeXHalf = blockSizeX / 2;
        float blockSizeYHalf = blockSizeY / 2;

        Dictionary<string, float> borderPosition = getBorderPositions();

        float leftBorderPosition = borderPosition["left"];
        float rightBorderPosition = borderPosition["right"];
        
        float cameraWidth = borderPosition["width"];
        float cameraHeight = borderPosition["height"];

        float blockCount = cameraWidth / blockSizeX;

        Debug.Log("Cameraheight " + cameraHeight);
        

        for (int j = 0; j < blockRows; j++ ) {
            
            float lastX = leftBorderPosition + 1 + blockSizeX/2;
            float lastY = cameraHeight / 4 - 1;
        
            for (int i = 0; i < blockCount; ++i ) {
                
                float y = cameraHeight / 4;
                Instantiate(BlockPrefab, new Vector2(lastX, lastY), Quaternion.identity);
                lastX += blockSizeX + 1;
            }

        }
        
    }

    
    public Dictionary<string, float> getBorderPositions () {

        // m_OrthographicCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        
        float height = 2f * m_OrthographicCamera.orthographicSize;
        float width = height * m_OrthographicCamera.aspect;
        
        float leftBorderPosition = -1f * (width / 2); 
        float rightBorderPosition = width / 2;
        
        var positionDict = new Dictionary<string, float> { 
            {"left", leftBorderPosition}, 
            {"right", rightBorderPosition},
            {"height", height},
            {"width", width}
        };

        return positionDict;
    }
}
