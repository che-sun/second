using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kimoeffect : MonoBehaviour
{
    GameObject player;
    Transform manboutrans;
    Transform kimotrans;
    Vector3 camerapos;
    Vector2 manboupos;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("manbou");
        manboutrans = player.GetComponent<Transform>();
        kimotrans = this.transform;
        StartCoroutine("jyumyou");
    }
    IEnumerator jyumyou()
    {
        yield return new WaitForSeconds(1.9f);
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        kimotrans.position = manboutrans.position;
    }
}
