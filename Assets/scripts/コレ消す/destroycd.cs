using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class destroycd : MonoBehaviour
{
    GameObject cdClone;
    GameObject colddead1;
    void Start()
    {
        colddead1 = (GameObject)Resources.Load("colddead1(Clone)");
        cdClone = GameObject.Find("colddead1(Clone)");
    }

    public void OnClick()
    {
        Destroy(cdClone);
        clickrelation.feel = "0";
    }
}
