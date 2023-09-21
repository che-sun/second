using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class destroyfs : MonoBehaviour
{
    GameObject fsClone;
    GameObject fishdead1;
    void Start()
    {
        fishdead1 = (GameObject)Resources.Load("fishdead1(Clone)");
        fsClone = GameObject.Find("fishdead1(Clone)");
    }

    public void OnClick()
    {
        Destroy(fsClone);
        clickrelation.feel = "0";
    }
}
