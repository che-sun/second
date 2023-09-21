using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class clickak : MonoBehaviour
{
    public GameObject canvas;
    GameObject ankoudead1;
    // Start is called before the first frame update
    void Start()
    {
        ankoudead1 = (GameObject)Resources.Load("ankoudead1");
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
            var instance = Instantiate(ankoudead1);
            instance.transform.SetParent(canvas.transform, false);
            clickrelation.feel = "1";
        }
    }
}