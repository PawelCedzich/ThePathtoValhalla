using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{

    private Queue<Sentence> Sentences;
    public Text QuestDialogField;
    public Text NpcName;

    public void StartDialog(Dialog dialog)
    {
        Sentences.Clear();

        foreach (Sentence sentence in dialog.sentences)
        {
            Sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        Sentence sentence;
        if (Sentences.Count == 0)
        {
            return;
        }

        sentence = Sentences.Dequeue();
        QuestDialogField.text = sentence.sentenceText;
        NpcName.text = sentence.Name;

    }


    void Start()
    {
        Sentences = new Queue<Sentence>();
    }

}
