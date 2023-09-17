using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acolona : MonoBehaviour
{
    GameObject colona;
    Transform colonatrans;
    Transform acolonatrans;
    Vector2 colonapos;
    // Start is called before the first frame update
    void Start()
    {
        colona = GameObject.Find("colona(Clone)");
        colonatrans = colona.GetComponent<Transform>();
        
        acolonatrans = this.gameObject.GetComponent<Transform>();
        StartCoroutine("colonajyumyou");
    }
    IEnumerator colonajyumyou()
    {
        yield return new WaitForSeconds(20);
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        colonapos = colonatrans.position;
        acolonatrans.position = colonapos;
    }
}
