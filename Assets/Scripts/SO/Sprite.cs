using UnityEngine;

namespace Game.Data
{
    public class SpriteDisplayer : MonoBehaviour
    {
        public Dialogs dialogData; 
        public int dialogIndex = 0; 

        private void Start()
        {
            if (dialogData != null && dialogData.Get.Length > dialogIndex)
            {
                Sprite characterSprite = dialogData.Get[dialogIndex].CharacterSprite; 

                if (characterSprite != null)
                {
                    SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

                    spriteRenderer.sprite = characterSprite; 
                }
            }
        }
    }
}
