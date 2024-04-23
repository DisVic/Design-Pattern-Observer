using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5f; // Скорость движения сферы

    void Update()
    {
        // Получаем входные данные по горизонтали и вертикали
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Создаем вектор направления движения
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Нормализуем вектор, чтобы движение в диагональных направлениях не было быстрее
        movement = movement.normalized;

        // Прибавляем к текущему положению сферы новое положение, умноженное на скорость и время
        transform.Translate(movement * speed * Time.deltaTime);
    }
}