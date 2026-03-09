using UnityEngine;

public class AlienMove : MonoBehaviour
{
    public float speed = 1f;
    public float moveDistance = 0.5f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float move = Mathf.Sin(Time.time * speed) * moveDistance;
        transform.position = startPos + new Vector3(move, 0, 0);
    }
}