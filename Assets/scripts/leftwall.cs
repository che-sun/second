using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftwall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("manbou"))
        {
            other.gameObject.transform.position = new Vector2(0, 0);
        }
        if (other.CompareTag("shark"))
        {
            Destroy(other.gameObject);
        }
    }
    void Update()
    {
        
    }
}
