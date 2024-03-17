using UnityEngine;

public class teste : MonoBehaviour
{
    public float followSpeed = 5f;
    public float verticalOffset = -0.5f; // Ajuste o valor conforme necessário
    public float maxYLimit = 5f;  // Limite máximo em Y
    private bool isFollowing = false;
    private Vector3 targetPosition;

    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            isFollowing = true;
        }

        if (isFollowing)
        {
            
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = transform.position.z;

            // Adicione um deslocamento vertical
            mousePosition.y += verticalOffset;

            // Limitar a posição de destino dentro do limite máximo em Y
            mousePosition.y = Mathf.Clamp(mousePosition.y, -Mathf.Infinity, maxYLimit);

            targetPosition = mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isFollowing = false;
        }

        if (isFollowing)
        {
            // Usar Lerp para suavizar o movimento
            transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
        }
    }
}
