using System.Collections.Generic;
using UnityEngine;
using System.Collections;

namespace Game.Data
{
    [CreateAssetMenu(menuName = "Game/Data/" + nameof(Dialogs))]
    public class Dialogs : ScriptableObject
    {
        [System.Serializable]
        public class Dialog
        {
            [SerializeField] private string _name;
            [SerializeField] [TextArea(minLines: 5, maxLines: 10)] private string _text;
            [SerializeField] private Sprite _characterSprite; 

            public string Name => _name;
            public string Text => _text;
            public Sprite CharacterSprite => _characterSprite; 
        }

        [SerializeField] private Dialog[] _dialogs;
        public Dialog[] Get => _dialogs;
    }
}
