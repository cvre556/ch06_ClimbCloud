using UnityEngine;

public class Background : MonoBehaviour
{
    public Transform[] backgrounds; // BG1, BG2 ��
    public float backgroundHeight;  // ��� �̹����� ����

    public Transform player; // �÷��̾� �Ǵ� ī�޶� ��ġ ����

    void Update()
    {
        foreach (Transform bg in backgrounds)  // ����̹��� �ݺ�
        {
            if (player.position.y - bg.position.y > backgroundHeight) // �÷��̾ ���1 ���� ����������
            {
                // ����� �������� �ű�� backgrounds.Length�� ����� ���� ���� ����� ��������� �ڿ������� �̾������� �ϱ� ����
                bg.position += new Vector3(0, backgroundHeight * backgrounds.Length, 0); 
            }
        }
    }
}
