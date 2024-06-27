using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    public int points = 10; // 衝突時に追加されるポイント

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("弾が衝突しました: " + collision.gameObject.name);

        // スコアを加算する
        ScoreManager.instance.AddScore(points);

        // 弾を削除する
        Destroy(gameObject);
    }
}