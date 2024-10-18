using UnityEngine;
using UnityEngine.UI;

public class DistanceTracker : MonoBehaviour
{
    public Text distanceText;
    public float speed = 5f;

    private float distanceTravelled;

    void Start()
    {
        distanceTravelled = 0f;
    }

    void Update()
    {
        // 距離を時間で計算
        distanceTravelled += speed * Time.deltaTime;
        distanceText.text = distanceTravelled.ToString("F1") + " m";

        // 現在の距離をGameManagerに保存
        GameManager.distanceTravelled = distanceTravelled;
    }
}
