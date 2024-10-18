using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text scoreText;

    void Update()
    {
        scoreText.text = ScoreManager.score + "ÉRÉCÉì";
    }
}

