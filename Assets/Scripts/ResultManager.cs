using UnityEngine;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour
{
    public Text ResultDistance;
    public Text ResultCoins; // Corrected the variable name for consistency
    public Text ResultPoint;

    void Start()
    {
        // Display distance travelled
        ResultDistance.text = GameManager.distanceTravelled.ToString("F1") + " m";

        // Display coins collected
        ResultCoins.text = GameManager.coinsCollected + " コイン";

        // Calculate points based on distance and coins
        int points = (int)(GameManager.distanceTravelled * 10 + GameManager.coinsCollected * 1000); // Cast to int
        ResultPoint.text = points.ToString() + " 点"; // Convert points to string after calculation
    }
}
