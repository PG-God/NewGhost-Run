using UnityEngine;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour
{
    public Text distanceText;
    public Text coinsText;

    void Start()
    {
        distanceText.text = GameManager.distanceTravelled.ToString("F1") + " m";
        coinsText.text = GameManager.coinsCollected + " コイン";
    }
}
