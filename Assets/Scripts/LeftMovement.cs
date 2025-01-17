using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMovement : MonoBehaviour
{
    public float speed;
    BoxCollider2D box;
    float groundWidht;
    float obstacleWidht;
    void Start()
    {

        if (gameObject.CompareTag("Ground"))
        {
            box = GetComponent<BoxCollider2D>();
            groundWidht = box.size.x;
        }
        else if (gameObject.CompareTag("Obstacle"))
        {
            obstacleWidht = GameObject.FindGameObjectWithTag("Column").GetComponent<BoxCollider2D>().size.x;
        }



    }

    void Update()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        if (gameObject.CompareTag("Ground"))
        {
            if (transform.position.x <= -groundWidht)
            {
                transform.position = new Vector2(transform.position.x + 2 * groundWidht, transform.position.y);
            }
        }



    }
}
