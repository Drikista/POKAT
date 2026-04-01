using System.Collections;
using UnityEngine;

public class Cam_Move : MonoBehaviour
{
    [Header("Posições X")]
    public float leftX = -19.2f;
    public float centerX = 0f;
    public float rightX = 19.2f;

    [Header("Configuração")]
    public float moveDuration = 0.5f;

    private int currentIndex = 1; // 0 = esquerda, 1 = centro, 2 = direita
    private bool isMoving = false;

    private void Update()
    {
        if (isMoving) return;

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveLeft();
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveRight();
        }
    }

    void MoveLeft()
    {
        // Se já está na esquerda, não faz nada
        if (currentIndex == 0) return;

        currentIndex--;
        StartCoroutine(MoveCamera(GetTargetX()));
    }

    void MoveRight()
    {
        // Se já está na direita, não faz nada
        if (currentIndex == 2) return;

        currentIndex++;
        StartCoroutine(MoveCamera(GetTargetX()));
    }

    float GetTargetX()
    {
        switch (currentIndex)
        {
            case 0: return leftX;
            case 1: return centerX;
            case 2: return rightX;
        }

        return centerX;
    }

    IEnumerator MoveCamera(float targetX)
    {
        isMoving = true;

        float startX = transform.position.x;
        float elapsed = 0f;

        while (elapsed < moveDuration)
        {
            elapsed += Time.deltaTime;
            float t = elapsed / moveDuration;

            float newX = Mathf.Lerp(startX, targetX, t);

            transform.position = new Vector3(
                newX,
                transform.position.y,
                transform.position.z
            );

            yield return null;
        }

        // Garante posição final exata
        transform.position = new Vector3(
            targetX,
            transform.position.y,
            transform.position.z
        );

        isMoving = false;
    }
}