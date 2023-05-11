using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemOnHover : MonoBehaviour
{
    public static ItemOnHover _Instance;

    public TextMeshProUGUI ItemDesc;
    public TextMeshProUGUI ItemValue;
    public Image ItemImage;

    private void Awake()
    {
        if (_Instance != null && _Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _Instance = this;
        }
    }
    void Start()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        this.transform.position = Input.mousePosition;
    }

    public void ShowItemDesc(string Description, Sprite sprite) 
    {
        gameObject.SetActive(true);
        ItemDesc.text = Description;
        this.transform.position = Input.mousePosition;
        ItemImage.sprite = sprite; 

    }

    public void HideItemDesc()
    {
        gameObject.SetActive(false);
    }


}
