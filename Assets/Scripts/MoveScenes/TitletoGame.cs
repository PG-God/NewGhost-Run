using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitletoGame : MonoBehaviour
{
    public void MoveAnimation()
    {
        SceneManager.LoadScene("GameScenes");
    }
}
