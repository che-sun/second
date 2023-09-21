using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class clickbb : MonoBehaviour
{
    public GameObject canvas;
    GameObject bubledead1;
    // Start is called before the first frame update
    void Start()
    {
        bubledead1 = (GameObject)Resources.Load("bubledead1");
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
            var instance = Instantiate(bubledead1);
            instance.transform.SetParent(canvas.transform, false);
            clickrelation.feel = "1";
        }
    }
}
