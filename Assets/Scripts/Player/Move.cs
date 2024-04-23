using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5f; // �������� �������� �����

    void Update()
    {
        // �������� ������� ������ �� ����������� � ���������
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // ������� ������ ����������� ��������
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // ����������� ������, ����� �������� � ������������ ������������ �� ���� �������
        movement = movement.normalized;

        // ���������� � �������� ��������� ����� ����� ���������, ���������� �� �������� � �����
        transform.Translate(movement * speed * Time.deltaTime);
    }
}