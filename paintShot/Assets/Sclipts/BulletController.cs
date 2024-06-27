using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    float power = 300; // 弾の発射力
    float speed = 1f;

    void Update()
    {
        // マウスの位置を取得
        Vector3 mousePos = Input.mousePosition;

        // 画面の真ん中を（0,0）にする
        mousePos.x = mousePos.x - (Screen.width / 2);
        mousePos.y = mousePos.y - (Screen.height / 2);

        // マウスの方向に回転させる
        Vector3 angle = transform.eulerAngles;

        angle.x = -mousePos.y * speed;
        angle.y = mousePos.x * speed;
        angle.z = 0;

        transform.eulerAngles = angle;

        // 左クリックで弾を打つ
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("弾を生成します");
            // クリックを押した時の処理
            // 弾生成
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            Debug.Log("弾が生成されました: " + bullet.name);

            // 弾が前に進むように力を加える
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Debug.Log("Rigidbodyが見つかりました。力を加えます。");
                rb.AddForce(transform.forward * power);
                Debug.Log("弾が発射されました。");
            }
            else
            {
                Debug.LogError("Rigidbodyが見つかりません。");
            }
        }
    }
}