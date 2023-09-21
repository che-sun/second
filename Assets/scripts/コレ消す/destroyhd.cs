using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class destroyhd : MonoBehaviour
{
    GameObject hdClone;
    GameObject hitodedead1;
    void Start()
    {
        hitodedead1 = (GameObject)Resources.Load("hitodedead1(Clone)");
        hdClone = GameObject.Find("hitodedead1(Clone)");
    }

    public void OnClick()
    {
        Destroy(hdClone);
        clickrelation.feel = "0";
    }
}
