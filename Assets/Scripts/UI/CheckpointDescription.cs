using UnityEngine;

public class CheckpointDescription : MonoBehaviour
{
    public DescriptionManager descriptionManager; // Ref to other script
    //Description
    public Sprite myInfoSprite; // Specific image description for a checkpoint
    public int myCheckpointID; // Checkpoint index
    //Distance
    private CalculateDistance myDistanceScript;
    
    void Start()
    {
        // Trova automaticamente lo script CalculateDistance attaccato a questo stesso oggetto
        myDistanceScript = GetComponent<CalculateDistance>();
    }
    
    
    // Function connected to Vuforia
    public void PushContentToUI()
    {
        if (descriptionManager != null)
        {
            descriptionManager.SetDescriptionContent(myInfoSprite);
            descriptionManager.SetCheckpointIndex(myCheckpointID);
        }

        if (myDistanceScript != null)
        {
            myDistanceScript.ShowMyDistance();
        }
    }
}