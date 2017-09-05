using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{

    public Rigidbody2D rb;

    public float speed = 5;
    public float jumpheight = 10;
    public Transform player;

    void Update()
    {
        if (Input.GetButtonDown("Play"))
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
        }

        // Move Right
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);

        }

        // Move Left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 180);
        }

        // Jumping
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
    }

    //void movement()
    //{
    //    // Move Right
    //    if (Input.GetKey(KeyCode.D))
    //    {
    //        transform.Translate(Vector2.right * speed * Time.deltaTime);
    //        transform.eulerAngles = new Vector2(0, 0);
            
    //    }

    //    // Move Left
    //    if (Input.GetKey(KeyCode.A))
    //    {
    //        transform.Translate(Vector2.right * speed * Time.deltaTime);
    //        transform.eulerAngles = new Vector2(0, 180);
    //    }

    //    // Jumping
    //    if (Input.GetKey(KeyCode.W))
    //    {
    //        transform.Translate(Vector2.up * speed * Time.deltaTime);
    //    }

    }
