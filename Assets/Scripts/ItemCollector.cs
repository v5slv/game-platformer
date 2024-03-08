using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    private int strawbs = 0;

    [SerializeField] private TextMeshProUGUI strawbsText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Strawberry"))
        {
            Destroy(collision.gameObject);
            strawbs++;
            strawbsText.text = "Strawberries : "+strawbs;
        }
   }
}
