using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBorders : MonoBehaviour
{

    public Camera m_OrthographicCamera;
    public GameObject BorderTop;
    public GameObject BorderBottom;
    public GameObject BorderLeft;
    public GameObject BorderRight;

    // Start is called before the first frame update
    void Start()
    {
        float height = 2f * m_OrthographicCamera.orthographicSize;
        float width = height * m_OrthographicCamera.aspect;

        float leftBorderPosition = -1f * (width / 2) + 0.5f; 
        float rightBorderPosition = width / 2 - 0.5f;

        BorderLeft.transform.position = new Vector3(leftBorderPosition, 0, 0);
        BorderRight.transform.position = new Vector3(rightBorderPosition, 0, 0);
        float spriteWidth = BorderTop.GetComponent<SpriteRenderer>().bounds.size.x;
        float ratio = width / spriteWidth;

        BorderTop.transform.localScale = new Vector3(ratio, 1, 1);
        BorderBottom.transform.localScale = new Vector3(ratio, 1, 1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}