using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;

    // �X�R�A�𑝂₷���\�b�h
    public static void AddScore(int amount)
    {
        score += amount;
        Debug.Log("Current Score: " + score);
    }}
