using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 2f;

    private Vector3 startPosition;
    private int direction = 1;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        transform.Translate(
            Vector2.right * direction * speed * Time.deltaTime
        );

        if (transform.position.x > startPosition.x + distance)
        {
            direction = -1;
        }
        else if (transform.position.x < startPosition.x - distance)
        {
            direction = 1;
        }
    }
}
