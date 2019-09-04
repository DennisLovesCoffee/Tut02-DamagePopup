using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField]
    private Transform damagePopupTransform;

    public void TakeDamage(int amount)
    {
        DamangePopupManager.instance.DisplayDamagePopup(amount, damagePopupTransform);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TakeDamage(Random.Range(10,25));
        }
    }
}
