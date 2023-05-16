using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{

    private Queue<string> Sentences;
    public Text QuestDialogField;
    public Text NpcName;

    public void StartDialog(Dialog dialog)
    {
        Sentences.Clear();
        NpcName.text = dialog.name;

        foreach (string sentence in dialog.sentences)
        {
            Sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        string sentence = "";
        QuestDialogField.text = sentence;
        if (Sentences.Count == 0) {
            EndDialog();
            return;
        }

        sentence = Sentences.Dequeue();
        QuestDialogField.text = sentence;

    }

    private void EndDialog()
    {
    }

    void Start()
    {
        Sentences = new Queue<string>();
    }

}
