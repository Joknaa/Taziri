using Fungus;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Taziri.Scripts {
    public class MenuManager : MonoBehaviour {
        [SerializeField] private Flowchart flowchart;
        [SerializeField] private Character you;
        [SerializeField] private Character mery;
        [SerializeField] private Character narrator;
        [SerializeField] private GameObject mainMenu;
        [SerializeField] private GameObject finishMenu_English;
        [SerializeField] private GameObject finishMenu_Hindi;


        public void SelectEnglish() {
            flowchart.SetStringVariable("Language", "English");
            you.name = "You";
            mery.name = "Mery";
            narrator.name = "Narrator";
        }

        public void SelectHindi() {
            flowchart.SetStringVariable("Language", "Hindi");
            you.name = "आप";
            mery.name = "मेरी";
            narrator.name = "कथावाचक";
        }

        public void ConfirmSelection() {
            mainMenu.SetActive(false);
        }

        public void DisplayFinishMenu_English() {
            finishMenu_English.SetActive(true);
        }
        public void DisplayFinishMenu_Hindi() {
            finishMenu_Hindi.SetActive(true);
        }

        public void Restart() {
            SceneManager.LoadScene(0);
        }

        public void Quite() {
            Application.Quit();
        }
    }
}