using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class destroyak : MonoBehaviour
{
    GameObject akClone;
    GameObject ankoudead1;
    void Start()
    {
        ankoudead1 = (GameObject)Resources.Load("ankoudead1(Clone)");
        akClone = GameObject.Find("ankoudead1(Clone)");
    }

    public void OnClick()
    {
        Destroy(akClone);
        clickrelation.feel = "0";
    }
}
