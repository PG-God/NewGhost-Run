using UnityEngine;
using UnityEngine.SceneManagement;

public class ResulttoGame : MonoBehaviour
{
    public void ReturnGame()
    {
        SceneManager.LoadScene("GameScenes");
    }
}
