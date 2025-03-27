using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextPagination : MonoBehaviour
{
    public TMP_Text storyText; // �� UI Text ���
    public Button nextButton; // �� Next ��ť
    public TMP_Text buttonText; // ��ť�ϵ�����
    public GameObject canvas; // ������ Canvas�����������

    private int currentIndex = 0; // ��ǰ�ı�����
    private bool finalTextShown = false; // �Ƿ��Ѿ���ʾ�����ı�

    // ����ı�����
    private string[] storyLines =
    {
        "The storm wrecked your ship�� You survived.",
        "This island feels�� off.",
        "They say pirate treasure lies buried here.",
        "A giant mushroom? Is there a goblin inside?",
        "A tent, a skull-topped spear�� Who was here before you?"
    };

    private string finalLine = "Let��s survive�� or perish trying."; // �����԰�

    void Start()
    {
        storyText.text = storyLines[currentIndex]; // ��ʾ��һ���ı�
        nextButton.onClick.AddListener(ShowNextText); // �󶨰�ť����¼�
    }

    void ShowNextText()
    {
        if (!finalTextShown) // ��δ���������ı�
        {
            if (currentIndex < storyLines.Length - 1)
            {
                currentIndex++;
                storyText.text = storyLines[currentIndex]; // �����ı�
            }
            else
            {
                // ��ʾ�����ı�
                storyText.text = finalLine;
                buttonText.text = "Oh no!"; // �ı䰴ť�ı�
                finalTextShown = true;
            }
        }
        else
        {
            // ���� Canvas
            canvas.SetActive(false);
        }
    }
}
