using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamagePopup : MonoBehaviour
{
    private TextMeshPro textMesh;
    
    private Color textColor;
    private Transform playerTransform;

    private float disappearTime = 0.5f;
    private float fadeOutSpeed = 5f;
    private float moveYSpeed = 1f;

    public void SetUp(int amount)
    {
        textMesh = GetComponent<TextMeshPro>();
        //playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        playerTransform = Camera.main.transform;

        textColor = textMesh.color;
        textMesh.SetText(amount.ToString());
    }

    private void LateUpdate()
    {
        transform.LookAt(2 *transform.position - playerTransform.position);

        transform.position += new Vector3(0f, moveYSpeed * Time.deltaTime, 0f);

        disappearTime -= Time.deltaTime;
        if (disappearTime < 0f)
        {
            textColor.a -= fadeOutSpeed * Time.deltaTime;
            textMesh.color = textColor;
            if (textColor.a <= 0f)
            {
                Destroy(gameObject);
            }
        }
    }
}
