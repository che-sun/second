using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class clickfs : MonoBehaviour
{
    public GameObject canvas;
    GameObject fishdead1;
    // Start is called before the first frame update
    void Start()
    {
        fishdead1 = (GameObject)Resources.Load("fishdead1");
        canvas = GameObject.Find("Canvas");


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Onclick()
    {
        if (clickrelation.feel == "0")
        {
            var instance = Instantiate(fishdead1);
            instance.transform.SetParent(canvas.transform, false);
            clickrelation.feel = "1";
        }
    }
}