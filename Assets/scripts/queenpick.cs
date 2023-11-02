using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class queenpick : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Image allow3;
    void Start()
    {
        if (PlayerPrefs.HasKey("queenpick") == false)
        {
            PlayerPrefs.SetInt("queenpick", 0);
            PlayerPrefs.Save();

        }
        if (PlayerPrefs.GetInt("queenpick", 0) == 1)
        {
            allow3.enabled = true;
        }
        if (PlayerPrefs.GetInt("queenpick", 0) == 0)
        {
            allow3.enabled = false;
        }
    }


    public void pick()
    {

        PlayerPrefs.SetInt("manpick", 0);
        PlayerPrefs.SetInt("huryoupick", 0);
        PlayerPrefs.SetInt("rougaipick", 0);
        PlayerPrefs.SetInt("queenpick", 1);
        PlayerPrefs.Save();
    }
    void Update()
    {
        if (PlayerPrefs.GetInt("queenpick", 0) == 1)
        {
            allow3.enabled = true;
        }
        if (PlayerPrefs.GetInt("queenpick", 0) == 0)
        {
            allow3.enabled = false;
        }
    }
}
