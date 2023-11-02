using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class rougaipick : MonoBehaviour
{
    [SerializeField]
    Image allow4;
    void Start()
    {
        if (PlayerPrefs.HasKey("rougaipick") == false)
        {
            PlayerPrefs.SetInt("rougaipick", 0);
            PlayerPrefs.Save();

        }
        if (PlayerPrefs.GetInt("rougaipick", 0) == 1)
        {
            allow4.enabled = true;
        }
        if (PlayerPrefs.GetInt("rougaipick", 0) == 0)
        {
            allow4.enabled = false;
        }
    }


    public void pick()
    {

        PlayerPrefs.SetInt("manpick", 0);
        PlayerPrefs.SetInt("huryoupick", 0);
        PlayerPrefs.SetInt("rougaipick", 1);
        PlayerPrefs.SetInt("queenpick", 0);
        PlayerPrefs.Save();
    }
    void Update()
    {
        if (PlayerPrefs.GetInt("rougaipick", 0) == 1)
        {
            allow4.enabled = true;
        }
        if (PlayerPrefs.GetInt("rougaipick", 0) == 0)
        {
            allow4.enabled = false;
        }
    }
}
