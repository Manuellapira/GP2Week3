using UnityEngine;
using UnityEngine.UI;
using jbmedina;  // Include the namespace

public class unknownsound : MonoBehaviour, IInteractable
{
    // Reference to the AudioSource component
    public AudioClip otherClip;

    // Start is called before the first frame update
    void Start()
    {
        // Get the AudioSource component attached to the same GameObject
        //audioSource = GetComponent<AudioClip>();

        // Get the Button component and assign the interaction
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(Interact);  // Attach Interact to button click
        }


        AudioSource audio = GetComponent<AudioSource>();

        audio.Play();
        audio.clip = otherClip;
        audio.Play();
    }



    // Implement the Interact method from the IInteractable interface
    public void Interact()
    {
        AudioSource audio = GetComponent<AudioSource>();

        
        audio.clip = otherClip;
        audio.Play();
    }
}
