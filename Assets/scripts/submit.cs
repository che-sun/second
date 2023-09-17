using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class submit : MonoBehaviour
{
    private string url = "http://waruguchi1.s205.xrea.com/save.php";
    GameObject gamemaster;
    gm gm;
    GameObject uimaster;
    GameObject nameObject;
    GameObject commentObject;
    InputField nameinputField;
    InputField commentinputField;
    GameObject score;
    Text score_text;
    bool flug=false;
    void Start()
    {
        gamemaster = GameObject.Find("gamemaster");
        uimaster = GameObject.Find("uimaster");
        gm = gamemaster.GetComponent<gm>();
        nameObject = GameObject.Find("name");
        commentObject = GameObject.Find("comment");
        nameinputField = nameObject.GetComponent<InputField>();
        commentinputField = commentObject.GetComponent<InputField>();
        score = GameObject.Find("time");
        score_text = score.GetComponent<Text>();
        bgmflug.loopflug = true;
    }
    void Update()
    {
        score_text.text = "タイム：" + gm.timer;
        gm.namepack = nameinputField.text;
        gm.commentpack = commentinputField.text;
        if (flug == true)
        {
            Destroy(gamemaster);
            Destroy(uimaster);
            SceneManager.LoadScene("opening");
        }
    }
    public void A()
    {
        StartCoroutine(WebRequest("test", "developing"));
    }
    IEnumerator WebRequest(string id, string pass)
    {

        WWWForm form = new WWWForm();
        form.AddField("name", gm.namepack);
        form.AddField("time", gm.timer.ToString());
        form.AddField("comment", gm.commentpack);
        UnityWebRequest request = UnityWebRequest.Post(url, form);

        // Basic認証用のAUTHORIZATIONヘッダー付加
        string authorization = authenticate(id, pass);
        request.SetRequestHeader("AUTHORIZATION", authorization);

        yield return request.SendWebRequest();

        if (request.isNetworkError)
        {
            Debug.Log(request.error);
        }
        else
        {
            Debug.Log(request.responseCode);
            flug = true;
        }
    }

    string authenticate(string username, string password)
    {
        string auth = username + ":" + password;
        auth = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(auth));
        auth = "Basic " + auth;
        return auth;
    }
}
