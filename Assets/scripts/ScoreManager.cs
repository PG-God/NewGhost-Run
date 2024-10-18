using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;

    // スコアを増やすメソッド
    public static void AddScore(int amount)
    {
        score += amount;
        Debug.Log("Current Score: " + score);
    }}
