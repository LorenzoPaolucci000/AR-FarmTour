using UnityEngine;
using System.Collections.Generic;

public class NextPlate : MonoBehaviour
{
    [Header("Select 3 dishes")]
    public List<GameObject> dishes; 
    private int currentIndex = 0; 

    void Start()
    {
        UpdateDishVisibility();
    }

    // Connected to the button
    public void NextDish()
    {
        dishes[currentIndex].SetActive(false);
        currentIndex++;
        
        if (currentIndex >= dishes.Count)
        {
            currentIndex = 0;
        }
        
        dishes[currentIndex].SetActive(true);
    }

    // Reset visualizzation
    void UpdateDishVisibility()
    {
        for (int i = 0; i < dishes.Count; i++)
        {
            if (i == 0) dishes[i].SetActive(true); // Turn on the first
            else dishes[i].SetActive(false);       // Turn off others
        }
        currentIndex = 0;
    }
    
}
