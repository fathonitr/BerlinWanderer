using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueTrigger : MonoBehaviour
{
    //to trigger a new dialogue

    public Dialogue dialogue;

    public TextMeshProUGUI text;

    public void TriggerDialogue()
    {
        FindObjectOfType <DialogueManager>().StartDialogue(dialogue);
    }

    public void HideText()
    {
        text.enabled = false;
    }
}
