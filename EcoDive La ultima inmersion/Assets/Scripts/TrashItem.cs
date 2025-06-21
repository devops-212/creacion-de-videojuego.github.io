using UnityEngine;

public class TrashItem : MonoBehaviour
{
    public float floatSpeed = 1f;     // Velocidad de movimiento vertical
    public float floatHeight = 0.5f;  // Altura m�xima de flotaci�n

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // Movimiento suave tipo flotaci�n
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
