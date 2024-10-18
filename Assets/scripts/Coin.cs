using UnityEngine;

public class Coin : MonoBehaviour
{
    // プレイヤーがコインに接触したときの処理
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("a");
        if (other.CompareTag("Character"))
        {
            // スコアを1増やす
            ScoreManager.AddScore(1);

            // コインを消す
            Destroy(gameObject);
            Debug.Log("コイン");
        }
    }
}
