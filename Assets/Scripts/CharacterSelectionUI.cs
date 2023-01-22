using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterSelectionUI : MonoBehaviour
{
    public GameObject OptionPrefab;

    public Transform PrevCharacter;
    public Transform SelectedCharacter;

    private void Start()
    {
        foreach (Character c in GameManager.instance.Characters)
        {
            GameObject option = Instantiate(OptionPrefab, transform);
            Button button = option.GetComponent<Button>();

            button.onClick.AddListener(() =>
            {
                GameManager.instance.SetCharacter(c);
                if (SelectedCharacter != null)
                {
                    PrevCharacter = SelectedCharacter;
                }

                SelectedCharacter = option.transform;
            });

            Text text = option.GetComponentInChildren<Text>();
            text.text = c.Name;

            Image image = option.GetComponentInChildren<Image>();
            image.sprite = c.Icon;
        }
    }

    private void Update()
    {
        if (SelectedCharacter != null)
        {
            SelectedCharacter.localScale = Vector3.Lerp(SelectedCharacter.localScale, new Vector3(1.2f, 1.2f, 1.2f), Time.deltaTime * 10);
        }

        if (PrevCharacter != null)
        {
            PrevCharacter.localScale = Vector3.Lerp(PrevCharacter.localScale, new Vector3(1f, 1f, 1f), Time.deltaTime * 10);
        }
    }

}
