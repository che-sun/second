using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manboupick : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Image allow1;
    void Start()
    {
        if (PlayerPrefs.HasKey("manpick") == false)
        {
            PlayerPrefs.SetInt("manpick", 1);
            PlayerPrefs.Save();

        }
        if (PlayerPrefs.GetInt("manpick", 1) == 1)
        {
            allow1.enabled = true;
        }
        if (PlayerPrefs.GetInt("manpick", 1) == 0)
        {
            allow1.enabled = false;
        }
    }

    
    public void pick()
    {

        PlayerPrefs.SetInt("manpick", 1);
        PlayerPrefs.SetInt("huryoupick", 0);
        PlayerPrefs.SetInt("rougaipick", 0);
        PlayerPrefs.SetInt("queenpick", 0);
        PlayerPrefs.Save();
    }
    void Update()
    {
        if (PlayerPrefs.GetInt("manpick", 1) == 1)
        {
            allow1.enabled = true;
        }
        if (PlayerPrefs.GetInt("manpick", 1) == 0)
        {
            allow1.enabled = false;
        }
    }
}
