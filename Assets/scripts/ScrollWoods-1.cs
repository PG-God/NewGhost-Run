using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float scrollSpeed = 5f;
    public float tileSizeX = 20f;

    private Vector3 startPosition;
    private float timer; // タイマーを追加
    void Start()
    {
        startPosition = transform.position;
        timer = 0f; // タイマーをリセット
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // タイマーを増加させる
        float newPosition = Mathf.Repeat(timer * scrollSpeed, tileSizeX);
        transform.position = startPosition + Vector3.left * newPosition;
    }
}
