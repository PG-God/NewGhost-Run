using UnityEngine;

public class Coin : MonoBehaviour
{
    // �v���C���[���R�C���ɐڐG�����Ƃ��̏���
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("a");
        if (other.CompareTag("Character"))
        {
            // �X�R�A��1���₷
            ScoreManager.AddScore(1);

            // �R�C��������
            Destroy(gameObject);
            Debug.Log("�R�C��");
        }
    }
}
