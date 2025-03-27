using UnityEngine;

public class ChangeSkybox : MonoBehaviour
{
    public Material[] skyboxes;  // �洢��� Skybox ����
    private int currentSkyboxIndex = 0; // ��¼��ǰ Skybox ����

    void Start()
    {
        if (skyboxes.Length > 0)
        {
            RenderSettings.skybox = skyboxes[currentSkyboxIndex]; // ����Ĭ�� Skybox
        }
    }

    public void ChangeSkyboxMaterial()
    {
        currentSkyboxIndex = (currentSkyboxIndex + 1) % skyboxes.Length; // �л�����һ�� Skybox
        RenderSettings.skybox = skyboxes[currentSkyboxIndex]; // Ӧ���µ� Skybox
        DynamicGI.UpdateEnvironment(); // ����ȫ�ֹ���
    }
}
