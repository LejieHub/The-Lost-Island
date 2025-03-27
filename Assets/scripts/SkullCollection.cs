using UnityEngine;
using System.Collections.Generic;

public class SkullCollection : MonoBehaviour
{
    [Header("Skull Collection")]
    public List<GameObject> skulls = new List<GameObject>(); // **�� Unity ����ק���ý�ȥ**
    private int collectedSkulls = 0; // **��¼���ռ�����������**

    [Header("Reward Settings")]
    public GameObject rewardObject; // **�����Ǳ��䡢��ʾ UI ����������**
    public bool unlockReward = false; // **�Ƿ��������**

    public AudioSource unlockSound;

    void Start()
    {
        if (skulls.Count == 0)
        {
            Debug.LogWarning("No skulls assigned! Please assign skull objects in the Inspector.");
        }
    }

    public void CollectSkull(GameObject skull)
    {
        skulls.Remove(skull); // **�� List ���Ƴ��������**
        Destroy(skull); // **�������ö���**
        collectedSkulls++; // **�����ռ�����**
        Debug.Log("Skull collected! " + collectedSkulls + "/6");

        if (collectedSkulls >= 6) // **����ռ��� 6 ��**
        {
            UnlockReward();
        }
    }

    void UnlockReward()
    {
        unlockReward = true; // **��ǽ�������**
        Debug.Log("All skulls collected! Reward unlocked!");

        if (rewardObject != null)
        {
            rewardObject.SetActive(true); // **��ʾ����������򿪱��䡢��ʾ UI��**
            unlockSound.Play();
        }
    }
}
