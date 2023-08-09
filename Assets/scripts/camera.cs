using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    GameObject player;
    Transform manboutrans;
    GameObject Camera;
    Transform cameratrans;
    Vector3 camerapos;
    Vector2 manboupos;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("manbou");
        manboutrans = player.GetComponent<Transform>();
        Camera = GameObject.Find("Camera");
        cameratrans = Camera.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        camerapos = cameratrans.position;
        manboupos = manboutrans.position;
        camerapos.x = manboupos.x;
        cameratrans.position = camerapos;
    }
}
