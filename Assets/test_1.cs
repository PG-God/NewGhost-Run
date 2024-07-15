using UnityEngine;
using UnityEngine.UI;

public class test_1 : MonoBehaviour
{
    [SerializeField] GameObject StartButton;

    public void CloseButtonfun()
    {
        StartButton.SetActive(false);
    }
}
