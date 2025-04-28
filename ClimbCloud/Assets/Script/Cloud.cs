using UnityEngine;

public class Cloud : MonoBehaviour
{
    public GameObject cloudPrefab; // ���� ������ ���� ������
    private float spawnInterval = 2f; // ���� ����
    private float minX = -2.0f; // X���� �ּҹ���
    private float maxX = 2.0f; // X���� �ִ����
    public float yOffset = 5f;  // �÷��̾� ���� ������ �����Ǵ� ���� ��
    public Transform player;

    private float nextSpawnY = 0f; // ���� ������ġ�� �����ϴ� �ڵ�

    void Start()
    {
        nextSpawnY = player.position.y + yOffset;
    }

    // Update is called once per frame
    void Update()
    {
        // �� �����Ӹ��� �÷��̾��� ��ġ�� Ȯ���ؼ�, �÷��̾ nextSpawnY���� �ö󰬴ٸ� ������ �ϳ� �����Ѵ�.
        if (player.position.y + yOffset > nextSpawnY)
        {
            CreateCloud(); // ���� ���� �Լ�
            nextSpawnY += spawnInterval; // ���� ������ ������ġ�� spawnInterval ��ŭ ������ �����Ѵ�
        }
    }

    void CreateCloud()
    {
        // minX maxX ������ ��ǥ��
        float randomX = Random.Range(minX, maxX);
        // ������ ������ ���� ��ġ ���� 
        Vector3 spawnPosition = new Vector3(randomX, nextSpawnY, 0f);
        //�ش� ��ġ�� ���� ������ ����
        Instantiate(cloudPrefab, spawnPosition, Quaternion.identity);
    }
}
