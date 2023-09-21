using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class clickcd : MonoBehaviour
{
   public GameObject canvas;
    GameObject colddead1;
    // Start is called before the first frame update
    void Start()
    {
        colddead1 = (GameObject)Resources.Load("colddead1");
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
            var instance = Instantiate(colddead1);
            instance.transform.SetParent(canvas.transform, false);
            clickrelation.feel = "1";
        }
    }
}
