using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Character_Code : MonoBehaviour
{
    Rigidbody2D rb2d;
    float moveX;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.zero;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveX = Input.GetAxis("Horizontal");
        Vector2 moveVector = new Vector2(moveX, 0f);
        rb2d.velocity = moveVector;
    }
}
