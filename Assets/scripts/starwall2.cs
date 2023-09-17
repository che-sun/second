using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starwall2 : MonoBehaviour
{
    GameObject player;
    Transform manboutrans;

    Transform cameratrans;
    Vector3 camerapos;
    Vector2 manboupos;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("manbou");
        manboutrans = player.GetComponent<Transform>();
        cameratrans = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        camerapos = cameratrans.position;
        manboupos = manboutrans.position;
        camerapos.x = manboupos.x-9.4f;
        cameratrans.position = camerapos;
    }
}
