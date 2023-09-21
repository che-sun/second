using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class destroypt : MonoBehaviour
{
    GameObject ptClone;
    GameObject proteindead1;
    void Start()
    {
        proteindead1 = (GameObject)Resources.Load("proteindead1(Clone)");
        ptClone = GameObject.Find("proteindead1(Clone)");
    }

    public void OnClick()
    {
        Destroy(ptClone);
        clickrelation.feel = "0";
    }
}
