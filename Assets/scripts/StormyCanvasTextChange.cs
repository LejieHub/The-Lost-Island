using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StormyCanvasTextChange : MonoBehaviour
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
        "A violent storm is approaching... You must take control of the ship before it's too late!",
    };

    private string finalLine = "Get to the helm and steady the ship!"; // �����԰�

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
                buttonText.text = "Got it!"; // �ı䰴ť�ı�
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
