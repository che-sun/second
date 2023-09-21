using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ColletoOp : MonoBehaviour
{
   
public void OnClick()
    {
        if(clickrelation.feel == "0")
        {
            SceneManager.LoadScene("opening");
        }
        
    }

    
}
