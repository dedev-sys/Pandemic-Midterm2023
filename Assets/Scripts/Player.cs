using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] public Locations locations;

    [SerializeField] private GameObject _location;
    [SerializeField] private TextMeshProUGUI _text;

    public GameObject _disease;

    private bool _treated;
    private bool _diseaseSpawn;
    private bool _move;
    private bool _moved;

    private float _speed = 2.0f;
    private Vector2 _moveto;

    // Start is called before the first frame update
    void Start()
    {
        InputManager.Init(this);
        _moveto = GameObject.Find("Locations/Centerville").transform.position;
        _move = true;
        _moved = false;
        changeText("Press [Space] to move", Color.blue);
    }

    void Update()
    {
        float step = _speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, _moveto, step);
    }

    public void Move()
    {
        if (_move == true)
        {
            _location = locations.getAllAdjacent(_location)[Random.Range(0, locations.getAllAdjacent(_location).Length)];
            //_location = GameObject.Find("Locations/Hub City");

            _moveto = _location.transform.position;
            _treated = false;
            _move = false;
            _moved = true;

            if (_location.transform.childCount > 0)
            {
                changeText("Press [T] to remove a disease piece", Color.red);
            }
            else
            {
                _treated = true;
                changeText("Click a city to add a disease piece", Color.green);
            }
        }
    }

    public void TreatDisease()
    {
        if (_treated == false && _moved == true && _location.transform.childCount > 0)
        {
            Destroy(_location.transform.GetChild(0).gameObject);
            _treated = true;
            changeText("Click a city to add a disease piece", Color.green);
        }
        else if (_moved == true)
        {
            _treated = true;
            changeText("Click a city to add a disease piece", Color.green);
        }
    }

    public void AddDisease(GameObject locationObject)
    {
        if (_treated == true && _moved == true)
        {
            if (locationObject.transform.childCount == 3)
            {
                GameObject[] adjacent = locations.getAllAdjacent(locationObject);
                foreach (GameObject i in adjacent)
                {
                    var newMultiDisease = Instantiate(_disease, i.transform.position, Quaternion.identity);
                    newMultiDisease.transform.parent = i.transform;
                }
            }

            var objectLocation = locationObject.transform.position;

            var newDisease = Instantiate(_disease, objectLocation, Quaternion.identity);
            newDisease.transform.parent = locationObject.transform;

            changeText("Press [Space] to move", Color.blue);
            _move = true;
            _moved = false;
        }
    }

    public void changeText(String t, Color c)
    {
        _text.text = t;
        _text.color = c;
    }
}
