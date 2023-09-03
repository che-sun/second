using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class um : MonoBehaviour
{
    GameObject gamemaster;
    GameObject siin;
    GameObject score;
    Text score_text;
    Text siin_text;
    gm gm;

    void Start()
    {
        gamemaster = GameObject.Find("gamemaster");
        siin = GameObject.Find("siin");
        score = GameObject.Find("time");
        siin_text = siin.GetComponent<Text>();
        score_text = score.GetComponent<Text>();
        gm = gamemaster.GetComponent<gm>();
    }

    // Update is called once per frame
    void Update()
    {
        score_text.text = "タイム：" + gm.timer;
        if (Input.GetMouseButton(0))
        {
            Destroy(gamemaster);
            SceneManager.LoadScene("opening");
        }
        if (gm.sibouflug == "cold")
        {
            siin_text.text = "寒すぎて死んだ。弱すぎwww";
        }
        if (gm.sibouflug == "jump")
        {
            siin_text.text = "寄生虫を落とそうとして水面からジャンプし、着水の際の衝撃で死んだ。馬鹿だね。";
        }
        if (gm.sibouflug == "shark")
        {
            siin_text.text = "サメに食われて死んだ。この世は弱肉強食だからね。しょうがないね。";
        }
        if (gm.sibouflug == "fish")
        {
            siin_text.text = "小魚に衝突して顔面を複雑骨折して死んだ。じゃあお前普段どうやって飯食ってんだよ。";
        }
        if (gm.sibouflug == "buble")
        {
            siin_text.text = "泡が目に入ったストレスで死んだ。お前まかり間違っても日本にだけは来るなよ。";
        }
        if (gm.sibouflug == "human")
        {
            siin_text.text = "人間に釣られて死んだ。ヒトカスなんぞにやられおって情けないぞ勇者マン＝ボウ！";
        }

    }
}
