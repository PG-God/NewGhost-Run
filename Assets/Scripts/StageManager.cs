using UnityEngine;

public class StageManager : MonoBehaviour
{
    public GameObject coinPrefab; // コインのPrefab
    public GameObject enemyPrefab; // 敵のPrefab
    public Transform player; // プレイヤーのTransform
    public float spawnDistance = 50f; // プレイヤーからどれくらい離れた位置に生成するか
    public float coinSpawnRate = 0.5f; // コイン生成確率（0〜1の範囲）
    public float enemySpawnRate = 0.3f; // 敵生成確率（0〜1の範囲）
    public float spawnRangeX = 5f; // 生成位置のX方向の範囲

    private void Update()
    {
        // プレイヤーが一定距離を移動したときに新しいオブジェクトを生成
        if (player.position.z > transform.position.z + spawnDistance)
        {
            SpawnObjects();
        }
    }

    private void SpawnObjects()
    {
        // 生成位置を決定
        Vector3 spawnPosition = new Vector3(
            Random.Range(-spawnRangeX, spawnRangeX), // X方向のランダム位置
            0f, // Y方向は固定
            transform.position.z // Z方向は現在の位置
        );

        // コインを生成するかどうかを判定
        if (Random.value < coinSpawnRate)
        {
            Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
        }

        // 敵を生成するかどうかを判定
        if (Random.value < enemySpawnRate)
        {
            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        }

        // ステージを更新
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + spawnDistance);
    }
}
