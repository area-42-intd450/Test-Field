using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dictionary : MonoBehaviour
{   
    public GameObject dictionaryUI;  // UI for the dictionary
    public GameObject wordContainer;  // parent objects for the word entries
    public GameObject wordEntryPrefab;  // prefab for the word entry
    private HashSet<string> learnedWords = new HashSet<string>();  // set of words in the dictionary

    public void AddWord(string word)
    {
        if (!learnedWords.Contains(word))
        {
            AddWordToUI(word);
        }
    }

    private void AddWordToUI(string word)
    {
        GameObject wordEntry = Instantiate(wordEntryPrefab, wordContainer.transform);
        TextMeshProUGUI wordText = wordEntry.GetComponentInChildren<TextMeshProUGUI>();
        wordText.text = word;
    }

    // Toggle the dictionary UI
    private void ToggleDictionary()
    {
        dictionaryUI.SetActive(!dictionaryUI.activeSelf);
    }
}
