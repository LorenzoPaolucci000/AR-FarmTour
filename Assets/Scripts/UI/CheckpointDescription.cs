using UnityEngine;

public class CheckpointDescription : MonoBehaviour
{
    public Sprite myInfoSprite; // Specific image description for a checkpoint
    public DescriptionManager descriptionManager; // Ref to other script
    public int myCheckpointID; // Checkpoint index
    // Function connected to Vuforia
    public void PushContentToUI()
    {
        if (descriptionManager != null)
        {
            descriptionManager.SetDescriptionContent(myInfoSprite);
            descriptionManager.SetCheckpointIndex(myCheckpointID);
        }
    }
}