﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CharactersMenu : MonoBehaviour
{

    #region Fields

    [SerializeField]
    private GameObject displayGameObject;
    private Text displayText;
    private string displayPre = "Selected character:\n";

    #endregion

    #region Unity API

    private void Start()
    {
        displayText = displayGameObject.GetComponent<Text>();
        displayText.text = displayPre + (CharacterName)PlayerPrefs.GetInt(Game.Constants.PreferencesKeys[Preference.Character]);
    }

    #endregion

    #region Methods

    private CharacterName GetCharacterName(string buttonGameObjectName)
    {
        switch (buttonGameObjectName)
        {
            case "Sebas":
                return CharacterName.Sebas;
            case "Camacho":
                return CharacterName.Camacho;
            case "Chavarria":
                return CharacterName.Chavarria;
            case "Ramon":
                return CharacterName.Ramon;
            case "Joaquin":
                return CharacterName.Joaquin;
            case "Maritza":
                return CharacterName.Maritza;
            case "Majo":
                return CharacterName.Majo;
            case "Lucia":
                return CharacterName.Lucia;
        }
        return CharacterName.Sebas;
    }

    #endregion

    #region Event Handlers

    public void HandleCharacterButtonOnClickEvent(GameObject gameObject)
    {
        PlayerPrefs.SetInt(Game.Constants.PreferencesKeys[Preference.Character], (int)GetCharacterName(gameObject.name));
        displayText.text = displayPre + gameObject.name;
    }

    public void HandlePlayButtonOnClickEvent()
    {
        MenuManager.GoToMenu(MenuName.Gameplay);
    }

    #endregion

}
