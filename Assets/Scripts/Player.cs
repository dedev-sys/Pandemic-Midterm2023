using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{

    [SerializeField] private GameObject _location;
    [SerializeField] private TextMeshProUGUI _text;

    private bool _treated;
    private bool _diseaseSpawn;

    // Start is called before the first frame update
    void Start()
    {
        InputManager.Init(this);
        changeText("Press [Space] to move", Color.blue);
    }

    public void Move()
    {
        transform.position = GameObject.Find("Locations/Hub City").transform.position;
        _location = GameObject.Find("Locations/Hub City");
        _treated = false;

        if (_location.transform.childCount > 0)
        {
            changeText("Press [T] to remove a disease piece", Color.red);
        }
    }

    public void TreatDisease()
    {
        if (_treated == false && _location.transform.childCount > 0)
        {
            Destroy(_location.transform.GetChild(0).gameObject);
            _treated = true;
        }
        changeText("Press [Space] to move", Color.blue);
    }

    public void AddDisease()
    {
        
    }

    public void changeText(String t, Color c)
    {
        _text.text = t;
        _text.color = c;
    }
}
