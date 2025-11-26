using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DescriptionManager : MonoBehaviour
{
    // "Panel-Description" image
    public Image displayImage; 
    // Checkpoint index
    public TextMeshProUGUI checkpointNumberText;
    
    public void SetDescriptionContent(Sprite newSprite)
    {
        if (displayImage != null && newSprite != null)
        {
            displayImage.sprite = newSprite;
        }
    }
    
    public void SetCheckpointIndex(int index)
    {
        if (checkpointNumberText != null)
        {
            checkpointNumberText.text = index.ToString() + " of 7";
        }
    }
}