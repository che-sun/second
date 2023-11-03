using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class um : MonoBehaviour
{
    GameObject gamemaster;
    GameObject siin;
    GameObject sharkdead;
    GameObject fishdead;
    GameObject bubledead;
    GameObject colddead;
    GameObject humandead;
    GameObject jumpdead;
    GameObject hitodedead;
    GameObject proteindead;
    GameObject colonadead;
    GameObject ankoudead;
    Text siin_text;
    gm gm;

    bool flug=true;
    bool flug2 = true;
    void Start()
    {
        gamemaster = GameObject.Find("gamemaster");
        siin = GameObject.Find("siin");
        siin_text = siin.GetComponent<Text>();
        gm = gamemaster.GetComponent<gm>();
        sharkdead = (GameObject)Resources.Load("sharkdead");
        fishdead = (GameObject)Resources.Load("fishdead");
        bubledead = (GameObject)Resources.Load("bubledead");
        humandead = (GameObject)Resources.Load("humandead");
        colddead = (GameObject)Resources.Load("colddead");
        jumpdead = (GameObject)Resources.Load("jumpdead");
        hitodedead = (GameObject)Resources.Load("hitodedead");
        proteindead = (GameObject)Resources.Load("proteindead");
        colonadead = (GameObject)Resources.Load("colonadead");
        ankoudead = (GameObject)Resources.Load("ankoudead");
        bgmflug.hardflug = 0;
    }
    void Update()
    {
        if (Input.GetMouseButton(0)&&flug==true)
        {
            flug = false;
            SceneManager.LoadScene("record");
        }
        if (gm.sibouflug == "cold" && flug == true && flug2 == true)
        {
            siin_text.text = "寒すぎて凍死した。弱すぎwww";
            Instantiate(colddead, new Vector2(0, 0.7f), Quaternion.Euler(0, 0, 0));
            if (PlayerPrefs.HasKey("coldpng") == false)
            {
                PlayerPrefs.SetInt("coldpng", 1);
                PlayerPrefs.Save();
            }
            flug2 = false;
        }
        if (gm.sibouflug == "jump" && flug == true && flug2 == true)
        {
            siin_text.text = "寄生虫を落とそうとして水面からジャンプし、着水の際の衝撃で死んだ。馬鹿だね。";
            Instantiate(jumpdead, new Vector2(0, 0.7f), Quaternion.Euler(0, 0, 0));
            if (PlayerPrefs.HasKey("jumppng") == false)
            {
                PlayerPrefs.SetInt("jumppng", 1);
                PlayerPrefs.Save();
            }
            flug2 = false;
        }
        if (gm.sibouflug == "shark" && flug == true && flug2 == true)
        {
            siin_text.text = "サメに食われて死んだ。この世は弱肉強食だからね。しょうがないね。";
            Instantiate(sharkdead, new Vector2(0, 0.7f), Quaternion.Euler(0, 0, 0));
            if (PlayerPrefs.HasKey("sharkpng") == false)
            {
                PlayerPrefs.SetInt("sharkpng", 1);
                PlayerPrefs.Save();
            }
            flug2 = false;
        }
        if (gm.sibouflug == "fish" && flug == true && flug2 == true)
        {
            siin_text.text = "小魚に衝突して顔面を複雑骨折して死んだ。じゃあお前普段どうやって飯食ってんだよ。";
            Instantiate(fishdead, new Vector2(0, 0.7f), Quaternion.Euler(0, 0, 0));
            if (PlayerPrefs.HasKey("fishpng") == false)
            {
                PlayerPrefs.SetInt("fishpng", 1);
                PlayerPrefs.Save();
            }
            flug2 = false;
        }
        if (gm.sibouflug == "buble" && flug == true && flug2 == true)
        {
            siin_text.text = "泡が目に入ったストレスで死んだ。お前まかり間違っても日本にだけは来るなよ。";
            Instantiate(bubledead, new Vector2(0, 0.7f), Quaternion.Euler(0, 0, 0));
            if (PlayerPrefs.HasKey("bublepng") == false)
            {
                PlayerPrefs.SetInt("bublepng", 1);
                PlayerPrefs.Save();
            }
            flug2 = false;
        }
        if (gm.sibouflug == "human" && flug == true && flug2 == true)
        {
            siin_text.text = "人間に釣られて死んだ。ヒトカスなんぞにやられおって情けないぞ勇者マン＝ボウ！";
            Instantiate(humandead, new Vector2(0, 0.7f), Quaternion.Euler(0, 0, 0));
            if (PlayerPrefs.HasKey("humanpng") == false)
            {
                PlayerPrefs.SetInt("humanpng", 1);
                PlayerPrefs.Save();
            }
            flug2 = false;
        }
        if (gm.sibouflug == "hitode" && flug == true && flug2 == true)
        {
            siin_text.text = "マ〇オのスターだと思っちゃったあ？wwwざあぁんねぇえんwwヒトデでしたあぁwヒトデに張り付かれて窒息して死ぬとかwざぁこ♡ざぁこ♡";
            Instantiate(hitodedead, new Vector2(0, 0.7f), Quaternion.Euler(0, 0, 0));
            if (PlayerPrefs.HasKey("hitodepng")==false)
            {
                PlayerPrefs.SetInt("hitodepng", 1);
                PlayerPrefs.Save();
            }
            flug2 = false;
        }
        if (gm.sibouflug == "ankou" && flug == true && flug2 == true)
        {
            siin_text.text = "チョウチンアンコウの光に誘われて食われた。お前虫じゃねえんだから光に吸収されるなよ。";
            Instantiate(ankoudead, new Vector2(0, 0.7f), Quaternion.Euler(0, 0, 0));
            if (PlayerPrefs.HasKey("ankoupng") == false)
            {
                PlayerPrefs.SetInt("ankoupng", 1);
                PlayerPrefs.Save();
            }
            flug2 = false;
        }
        if (gm.sibouflug == "muteki" && flug == true && flug2 == true)
        {
            siin_text.text = "プロテインの接種後、身に余る力により筋肉痛になって死んだ。大いなる力には大いなる責任（死）が伴うのじゃマン＝ボウよ...";
            Instantiate(proteindead, new Vector2(0, 0.7f), Quaternion.Euler(0, 0, 0));
            if (PlayerPrefs.HasKey("mutekipng") == false)
            {
                PlayerPrefs.SetInt("mutekipng", 1);
                PlayerPrefs.Save();
            }
            flug2 = false;
        }
        if (gm.sibouflug == "colona" && flug == true && flug2 == true)
        {
            siin_text.text = "コロナに感染して死んだ。海洋生物ってコロナ感染とかするんか？...(困惑)";
            Instantiate(colonadead, new Vector2(0, 0.7f), Quaternion.Euler(0, 0, 0));
            if (PlayerPrefs.HasKey("colonapng") == false)
            {
                PlayerPrefs.SetInt("colonapng", 1);
                PlayerPrefs.Save();
            }
            flug2 = false;
        }
        if (gm.sibouflug == "colona-a" && flug == true && flug2 == true)
        {
            siin_text.text = "コロナに感染して死んだ。海洋生物ってコロナ感染とかするんか？...(※寄生虫に突破されるバリアなんだからウイルスなんて防護できないに決まってんだろ)";
            Instantiate(colonadead, new Vector2(0, 0.7f), Quaternion.Euler(0, 0, 0));
            if (PlayerPrefs.HasKey("colonapng") == false)
            {
                PlayerPrefs.SetInt("colonapng", 1);
                PlayerPrefs.Save();
            }
            flug2 = false;
        }
        if (gm.sibouflug == "colona-b" && flug == true && flug2 == true)
        {
            siin_text.text = "コロナに感染して死んだ。海洋生物ってコロナ感染とかするんか？...(※ウイルスに嗅覚あるわけないだろ)";
            Instantiate(colonadead, new Vector2(0, 0.7f), Quaternion.Euler(0, 0, 0));
            if (PlayerPrefs.HasKey("colonapng") == false)
            {
                PlayerPrefs.SetInt("colonapng", 1);
                PlayerPrefs.Save();
            }
            flug2 = false;
        }

    }
}
