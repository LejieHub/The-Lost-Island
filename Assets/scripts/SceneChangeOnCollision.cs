using UnityEngine;
using UnityEngine.SceneManagement;

public class OceanCollision : MonoBehaviour
{
    [SerializeField] private GameObject player; // �ֶ���ק��Ҷ���
    [SerializeField] private string sceneToLoad; // �ֶ����ó�������

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player) // ȷ�������
        {
            SceneManager.LoadScene(sceneToLoad); // �л�����
        }
    }
}
