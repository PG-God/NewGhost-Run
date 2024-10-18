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
        distanceTravelled += speed * Time.deltaTime;
        distanceText.text = distanceTravelled.ToString("F1") + " m";
    }
}
