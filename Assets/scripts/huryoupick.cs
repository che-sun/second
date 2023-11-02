using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class huryoupick : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Image allow2;
    void Start()
    {
        if (PlayerPrefs.HasKey("huryoupick") == false)
        {
            PlayerPrefs.SetInt("huryoupick", 0);
            PlayerPrefs.Save();

        }
        if (PlayerPrefs.GetInt("huryoupick", 0) == 1)
        {
            allow2.enabled = true;
        }
        if (PlayerPrefs.GetInt("huryoupick", 0) == 0)
        {
            allow2.enabled = false;
        }
    }


    public void pick()
    {

        PlayerPrefs.SetInt("manpick", 0);
        PlayerPrefs.SetInt("huryoupick", 1);
        PlayerPrefs.SetInt("rougaipick", 0);
        PlayerPrefs.SetInt("queenpick", 0);
        PlayerPrefs.Save();
    }
    void Update()
    {
        if (PlayerPrefs.GetInt("huryoupick", 0) == 1)
        {
            allow2.enabled = true;
        }
        if (PlayerPrefs.GetInt("huryoupick", 0) == 0)
        {
            allow2.enabled = false;
        }
    }
}
