using UnityEngine;

public class CheckpointDescription : MonoBehaviour
{
    public DescriptionManager descriptionManager; // Ref to other script
    //Description
    public Sprite myInfoSprite; // Specific image description for a checkpoint
    public int myCheckpointID; // Checkpoint index
    //Distance
    private CalculateDistance myDistanceScript;
    //Audio
    public AudioClip myAudioClip; // mp3 track
    public AudioManager audioManager; // ref
    void Start()
    {
        // Trova automaticamente lo script CalculateDistance attaccato a questo stesso oggetto
        myDistanceScript = GetComponent<CalculateDistance>();
    }
    
    
    // Function connected to Vuforia
    public void PushContentToUI()
    {
        // Images and text
        if (descriptionManager != null)
        {
            descriptionManager.SetDescriptionContent(myInfoSprite);
            descriptionManager.SetCheckpointIndex(myCheckpointID);
        }
        // Distance
        if (myDistanceScript != null)
        {
            myDistanceScript.ShowMyDistance();
        }
        //Audio 
        if (audioManager != null && myAudioClip != null)
        {
            audioManager.PlayNewTrack(myAudioClip);
        }
    }
}