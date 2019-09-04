using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamangePopupManager : MonoBehaviour
{
    #region Singleton

    public static DamangePopupManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.Log("We messed UP!!");
        }
    }

    #endregion


    [SerializeField]
    private GameObject damagePopupPrefab;


    public void DisplayDamagePopup(int amount, Transform popupParent)
    {
        GameObject damagePopup = Instantiate(damagePopupPrefab, popupParent.transform.position, Quaternion.identity, popupParent);
        damagePopup.GetComponent<DamagePopup>().SetUp(amount);
    }
}
