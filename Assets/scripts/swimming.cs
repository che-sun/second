using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swimming : MonoBehaviour
{
    public float speed = 0.01f;
    public float slideR = 0.01f;
    public float slideL = -0.01f;
    public float unjump = 0.03f;
    public float jump = 0.02f;
    private Rigidbody2D rigidbody = null;
    private SpriteRenderer spriteRenderer = null;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody2D>();
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = this.rigidbody.position;

        if (Input.GetKeyDown(KeyCode.A))
        {
            rigidbody.AddForce(new Vector2(-slideL, 0), ForceMode2D.Impulse);
            spriteRenderer.flipX = false;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rigidbody.AddForce(new Vector2(slideR, 0), ForceMode2D.Impulse);
            spriteRenderer.flipX = true;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            rigidbody.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rigidbody.AddForce(new Vector2(0, -unjump), ForceMode2D.Impulse);
        }
        this.transform.position = pos;
    }

}
