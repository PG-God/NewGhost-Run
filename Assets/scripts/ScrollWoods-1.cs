using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float scrollSpeed = 5f;
    public float tileSizeX = 20f;

    private Vector3 startPosition;
    private float timer; // �^�C�}�[��ǉ�
    void Start()
    {
        startPosition = transform.position;
        timer = 0f; // �^�C�}�[�����Z�b�g
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // �^�C�}�[�𑝉�������
        float newPosition = Mathf.Repeat(timer * scrollSpeed, tileSizeX);
        transform.position = startPosition + Vector3.left * newPosition;
    }
}
