using UnityEngine;
using TMPro;

public class High : MonoBehaviour
{
    public Transform player; // �÷��̾� ������Ʈ
    public TextMeshProUGUI highText; // ���̸� ǥ���� UI Text

    private float maxHeight = 0f; // �ְ� ���� ���

    void Update()
    {
        // �÷��̾ ���� �ְ� ���̺��� ���� �ö��� ��� ����
        if (player.position.y > maxHeight)
        {
            maxHeight = player.position.y;
            highText.text = maxHeight.ToString("F1") + "m";
        }
    }
}
