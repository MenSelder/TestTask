using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayableCharacter : ChosableDataObject
{
    [SerializeField] private string name;
    [SerializeField] private string level;
    [SerializeField] private Sprite avatar;
    [SerializeField] private GameObject model;
}
