using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Zenject;

public class ItemCounter : MonoBehaviour
{
    private Storage _storage;

    [Inject]
    private void Init(Storage storage)
    {
        _storage = storage;
        _storage.ChangeCountEvent += Change;
    }

    void Start() => Change(0);

    private void Change(int count)
    {
        GetComponent<TMP_Text>().text = "Items: " + count;
    }
}
