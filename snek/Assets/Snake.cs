using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Snake : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 dir = Vector2.right;
    List<Transform> tail = new List<Transform>();

    public bool ate = false;

    public GameObject tailPrefab;

    void Start()
    {
        InvokeRepeating("Move", 0.2f, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {  
        if (Input.GetKey(KeyCode.RightArrow)) {
            dir = Vector2.right;
        }
        else if (Input.GetKey(KeyCode.DownArrow)) {
            dir = -Vector2.up;
        }
        else if (Input.GetKey(KeyCode.LeftArrow)) {
            dir = -Vector2.right;
        }
        else if (Input.GetKey(KeyCode.UpArrow)) {
            dir = Vector2.up;
        }

    }

    void Move() {
        // Move here

        Vector2 v = transform.position;

        transform.Translate(dir);

        if (ate) {
            // Load prefab into the world
            GameObject g = (GameObject) Instantiate(tailPrefab, 
            v, 
            Quaternion.identity);

            // keep track of it in our tail list
            tail.Insert(0, g.transform);
            ate = false;
        }

        // Do we have a Tail?
        else if (tail.Count > 0) {
            tail.Last().position = v;

            tail.Insert(0, tail.Last());
            tail.RemoveAt(tail.Count - 1);
        }
    }

    void OnTriggerEnter2D (Collider2D coll) {

        Debug.Log("Ate food");

        if (coll.name.StartsWith("FoodPrefab")) {
            ate = true;
            Destroy(coll.gameObject);
        }

        else {

        }
    }
}
