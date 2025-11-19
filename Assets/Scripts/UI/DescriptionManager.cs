using UnityEngine;
using UnityEngine.UI;

public class DescriptionManager : MonoBehaviour
{
    // "Panel-Description" image
    public Image displayImage; 
    
    public void SetDescriptionContent(Sprite newSprite)
    {
        if (displayImage != null && newSprite != null)
        {
            displayImage.sprite = newSprite;
        }
    }
}