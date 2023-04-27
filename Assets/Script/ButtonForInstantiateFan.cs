using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class ButtonForInstantiateFan : MonoBehaviour
{
    public float timeLeft = 5.0f;
    public TextMeshProUGUI countdownText;

    private GameObject fanInstance;

    [SerializeField] private Image imageForFan;
    [SerializeField] private GameObject fanPrefab;
    [SerializeField] private GameObject fanSpondPosition;

    public Button buttonFor5Second;

    private bool instantiated = false;

    private void Start()
    {
        imageForFan.gameObject.SetActive(false);
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            countdownText.gameObject.SetActive(false);
            imageForFan.gameObject.SetActive(true);
            buttonFor5Second.onClick.AddListener(InstantiateFan);
        }
        else
        {
            countdownText.text ="" + Mathf.RoundToInt(timeLeft);
            
        }
    }

    void InstantiateFan()
    {
        if(!instantiated)
        {
            if (Input.GetMouseButtonDown(0) || Input.touchCount > 0 ) 
            {
                //Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                Vector3 touchPos = fanSpondPosition.transform.position;
                fanInstance = Instantiate(fanPrefab, touchPos, Quaternion.identity);
                fanInstance.AddComponent<DrageActiveForTheFan>();
                instantiated = true;
                Debug.Log("okay");
            }
            

            imageForFan.gameObject.SetActive(false);
            countdownText.gameObject.SetActive(true);
            timeLeft = 5f;
        }
    }
}
