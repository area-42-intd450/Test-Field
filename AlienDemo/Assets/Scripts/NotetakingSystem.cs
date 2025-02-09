using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject dialogueBox;
    public TextMeshProUGUI noteDisplay;
    private List<string> notes = new List<string>();

    // call when setting dialogue text
    public void DisplayDialogue(string dialogue)
    {
        // clear existing children in the box
        foreach (Transform child in dialogueBox.transform)
        {
            Destroy(child.gameObject);
        }

        //split the dialogue into words
        string[] words = dialogue.Split(' ');

        // create a new button for each word
        foreach (string word in words)
        {
            GameObject wordButton = new GameObject(word);
            Button button = wordButton.AddComponent<Button>();
            TextMeshProUGUI buttonText = wordButton.AddComponent<TextMeshProUGUI>();

            // set the button text
            buttonText.text = word;
            buttonText.fontSize = 24;
            buttonText.color = Color.black;

            wordButton.transform.SetParent(dialogueBox.transform);
            button.onClick.AddListener(() => AddToNotes(word));        
        }
    }

    public void AddToNotes(string note)
    {
        notes.Add(note);
        UpdateNoteDisplay();
    }

    private void UpdateNoteDisplay()
    {
        noteDisplay.text = string.Join(" ", notes.ToArray());
    }
}
