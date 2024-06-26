using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    float power = 300;
    float speed = 0.1f;
    void Update()
    {
        //マウスの位置を取得
        Vector3 mousePos = Input.mousePosition;

        //画面の真ん中を（0,0）にする
        mousePos.x = mousePos.x - (Screen.width / 2);
        mousePos.y = mousePos.y - (Screen.height / 2);

        // マウスの方向に回転させる
        Vector3 angle = transform.eulerAngles;

        angle.x = -mousePos.y * speed;
        angle.y = mousePos.x * speed;
        angle.z = 0;

        transform.eulerAngles = angle;
        //左クリックで弾を打つ
        if (Input.GetMouseButtonDown(0))
        {
            // クリックを押した時の処理
            //弾生成
           GameObject bullet =  Instantiate(bulletPrefab, transform.position, transform.rotation);
           //弾が前に進むように力を加える
           bullet.GetComponent<Rigidbody>().AddForce(transform.forward * power);
        }
    }
}
