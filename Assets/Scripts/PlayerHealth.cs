using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHeartsUI();
    }

    void UpdateHeartsUI()
    {
        heart1.SetActive(currentHealth >= 1);
        heart2.SetActive(currentHealth >= 2);
        heart3.SetActive(currentHealth >= 3);
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        UpdateHeartsUI();

        if (currentHealth <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        // ゲームオーバー時にResultScenesへ
        SceneManager.LoadScene("ResultScenes");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(1);
        }

        // もしコインを取得したら（仮にコインに "Coin" タグがついているとする）
        if (other.gameObject.CompareTag("Coin"))
        {
            GameManager.coinsCollected++;  // コインの数を加算
            Destroy(other.gameObject);  // コインを削除
        }
    }
}
