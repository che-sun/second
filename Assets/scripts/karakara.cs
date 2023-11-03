using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esa : MonoBehaviour
{
    [SerializeField] List<GameObject> EsaList;  // �����I�u�W�F�N�g
    [SerializeField] Transform pos;           // �����ʒu
    [SerializeField] Transform pos2;          // �����ʒu
    [SerializeField] Transform manboutrans;   // �}���{�E��Transform
    [SerializeField] int maxFoodCount = 15;
    [SerializeField] Transform camera;

    float minX, maxX, minY, maxY; // �����͈�

    int frame = 0;
    public int foodCount = 0;
    [SerializeField] int generateFrame = 30; // ��������Ԋu

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

                // �����_���Ŏ�ނƈʒu�����߂�
                int index = Random.Range(0, EsaList.Count);
                float posY = Random.Range(minY - 4, maxY + 4);
                Vector3 manboupos = manboutrans.position;

                float randomX = Random.Range(manboupos.x + 10, manboupos.x + 30); // �}���{�E�̈ʒu���烉���_����x���W�𐶐�
                Vector3 spawnPosition = new Vector3(randomX, posY, 0);

                Instantiate(EsaList[index], spawnPosition, Quaternion.identity);

            }

        }
    }


}