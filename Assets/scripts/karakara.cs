using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esa : MonoBehaviour
{
    [SerializeField] List<GameObject> EsaList;  // 生成オブジェクト
    [SerializeField] Transform pos;           // 生成位置
    [SerializeField] Transform pos2;          // 生成位置
    [SerializeField] Transform manboutrans;   // マンボウのTransform
    [SerializeField] int maxFoodCount = 15;
    [SerializeField] Transform camera;

    float minX, maxX, minY, maxY; // 生成範囲

    int frame = 0;
    public int foodCount = 0;
    [SerializeField] int generateFrame = 30; // 生成する間隔

    void Start()
    {
        minX = Mathf.Min(pos.position.x, pos2.position.x);
        maxX = Mathf.Max(pos.position.x, pos2.position.x);
        minY = Mathf.Min(pos.position.y, pos2.position.y);
        maxY = Mathf.Max(pos.position.y, pos2.position.y);

    }

    void Update()
    {
        ++frame;
        if (maxFoodCount > foodCount)
        {
            if (frame > generateFrame)
            {
                frame = 0;
                foodCount++;

                // ランダムで種類と位置を決める
                int index = Random.Range(0, EsaList.Count);
                float posY = Random.Range(minY - 4, maxY + 4);
                Vector3 manboupos = manboutrans.position;

                float randomX = Random.Range(manboupos.x + 10, manboupos.x + 30); // マンボウの位置からランダムなx座標を生成
                Vector3 spawnPosition = new Vector3(randomX, posY, 0);

                Instantiate(EsaList[index], spawnPosition, Quaternion.identity);

            }

        }
    }


}