using Fungus;
using UnityEngine;

namespace Taziri.Scripts {
    public class MenuManager : MonoBehaviour {
        [SerializeField] private Flowchart flowchart;
        [SerializeField] private GameObject MainMenu;

    

        public void SelectEnglish() {
            flowchart.SetStringVariable("Language", "English");
        }
        public void SelectHindi() {
            flowchart.SetStringVariable("Language", "Hindi");
        }

        public void ConfirmSelection() {
            MainMenu.SetActive(false);
        }
    }
}