using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightwall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("manbou"))
        {
            other.gameObject.transform.position = new Vector2(-400, 0);
        }
        if (other.CompareTag("fish"))
        {
            Destroy(other.gameObject);
        }
    }
    void Update()
    {
        
    }
}
