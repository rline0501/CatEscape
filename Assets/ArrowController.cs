using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player"); 
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0, -0.1f, 0);
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);

        }

        //�����蔻��

        Vector2 p1 = transform.position;         //��̒��S���W
        Vector2 p2 = this.player.transform.position;   //�v���C���\�̒��S���W
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;  //��̔��a
        float r2 = 1.0f;  //�v���C���[�̔��a

        if(d < r1 + r2)
        {
            //�ēX�N���v�g�Ƀv���C���[�ƏՓ˂������Ƃ�`����
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();

            //�Փ˂����ꍇ�͖������
            Destroy(gameObject);

        }

    }


}