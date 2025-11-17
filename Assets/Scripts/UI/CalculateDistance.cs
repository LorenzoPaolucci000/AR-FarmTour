using UnityEngine;
using TMPro;

public class CalculateDistance : MonoBehaviour
{
    public Camera arCamera; 
    public TMP_Text distanceText;

    void Update()
    {
        if (arCamera == null || distanceText == null) return;

        float distance = Vector3.Distance(transform.position, arCamera.transform.position);
        
        distanceText.text = distance.ToString("F0") + " cm";
    }
}
