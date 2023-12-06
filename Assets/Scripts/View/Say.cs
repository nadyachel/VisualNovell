using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Data;
using TMPro;
   
namespace Game.View
{ 
public class Say : MonoBehaviour
{
        [SerializeField] private Dialogs _dialogs;
        [SerializeField] private TextMeshProUGUI _name;
        [SerializeField] private TextMeshProUGUI _text;
        
        private int _index;
        
        private void Start()
        {
            if (_dialogs != null) NextDialog();
        }

        public void NextDialog()
        {
            if (_index == _dialogs.Get.Length) return;
            _name.SetText(_dialogs.Get[_index].Name);
            _text.SetText(_dialogs.Get[_index].Text);

          

            _index++;
        }
    }
}
