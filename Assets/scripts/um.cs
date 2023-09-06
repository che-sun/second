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

    bool flug=true;
    void Start()
    {
        gamemaster = GameObject.Find("gamemaster");
        siin = GameObject.Find("siin");
        score = GameObject.Find("time");
        siin_text = siin.GetComponent<Text>();
        score_text = score.GetComponent<Text>();
        gm = gamemaster.GetComponent<gm>();
    }
    void Update()
    {
        score_text.text = "タイム：" + gm.timer;
        if (Input.GetMouseButton(0)&&flug==true)
        {
            flug = false;
            SceneManager.LoadScene("record");
        }
        if (gm.sibouflug == "cold" && flug == true)
        {
            siin_text.text = "寒すぎて死んだ。弱すぎwww";
        }
        if (gm.sibouflug == "jump" && flug == true)
        {
            siin_text.text = "寄生虫を落とそうとして水面からジャンプし、着水の際の衝撃で死んだ。馬鹿だね。";
        }
        if (gm.sibouflug == "shark" && flug == true)
        {
            siin_text.text = "サメに食われて死んだ。この世は弱肉強食だからね。しょうがないね。";
        }
        if (gm.sibouflug == "fish" && flug == true)
        {
            siin_text.text = "小魚に衝突して顔面を複雑骨折して死んだ。じゃあお前普段どうやって飯食ってんだよ。";
        }
        if (gm.sibouflug == "buble" && flug == true)
        {
            siin_text.text = "泡が目に入ったストレスで死んだ。お前まかり間違っても日本にだけは来るなよ。";
        }
        if (gm.sibouflug == "human" && flug == true)
        {
            siin_text.text = "人間に釣られて死んだ。ヒトカスなんぞにやられおって情けないぞ勇者マン＝ボウ！";
        }
        if (gm.sibouflug == "hitode" && flug == true)
        {
            siin_text.text = "マ〇オのスターだと思っちゃったあ？wwwざあぁんねぇえんwwヒトデでしたあぁwざぁこ♡ざぁこ♡";
        }
    }
}
