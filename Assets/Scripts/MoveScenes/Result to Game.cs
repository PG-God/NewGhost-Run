using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResulttoGame : MonoBehaviour
{
    public void ReturnGame()
    {
        SceneManager.LoadScene("GameScenes");
    }
}
