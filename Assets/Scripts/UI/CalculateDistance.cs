using UnityEngine;
using TMPro;

public class CalculateDistance : MonoBehaviour
{
    public int nextMarkDistance; 
    public TextMeshProUGUI uiDistanceText; 


    public void ShowMyDistance()
    {
        if (uiDistanceText != null)
        {
            if (nextMarkDistance <= 0)
            {
                uiDistanceText.text = "";
            }
            else
            {
                uiDistanceText.text = "About " + nextMarkDistance.ToString() + " m";
            }
        }
    }
}