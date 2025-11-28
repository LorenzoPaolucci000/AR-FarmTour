using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VectorGraphics;
public class DescriptionManager : MonoBehaviour
{
    // "Panel-Description" image
    public SVGImage displayImage; 
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