using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{   
    public Rigidbody2D rb2d;
    public float speed = 20.0f;
    KeyCode moveLeft = KeyCode.LeftArrow;
    KeyCode moveRight = KeyCode.RightArrow;
    // Start is called before the first frame update
    public Camera m_OrthographicCamera;
    public float leftBorderPosition;
    public float rightBorderPosition;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        float height = 2f * m_OrthographicCamera.orthographicSize;
        float width = height * m_OrthographicCamera.aspect;

        float leftBorderPosition = -1f * (width / 2) + 0.5f; 
        float rightBorderPosition = width / 2 - 0.5f;
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
