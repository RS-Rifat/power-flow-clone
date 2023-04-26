using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Bullet : MonoBehaviour
{

    [SerializeField] private int chargeValue = 1;
    [SerializeField] private TextMeshPro chargeValueText;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EndPoint"))
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {  
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("+24"))
        {
            int value = 24;
            chargeValue = chargeValue + value;
            chargeValueText.text = chargeValue.ToString();
        }

        if (other.CompareTag("+62"))
        {
            int value = 62;
            chargeValue = chargeValue + value;
            chargeValueText.text = chargeValue.ToString();
        }

        if (other.CompareTag("+99"))
        {
            int value = 99;
            chargeValue = chargeValue + value;
            chargeValueText.text = chargeValue.ToString();
        }
    }
}
