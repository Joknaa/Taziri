using Fungus;
using UnityEngine;

namespace Taziri.Scripts {
    public class LanguageManager : MonoBehaviour{
        [SerializeField] private Flowchart flowchart;
        [SerializeField] private Character you;
        [SerializeField] private Character mery;
        [SerializeField] private Character narrator;


        public void SetUpEnglish() {
            flowchart.SetStringVariable("Language", "English");
            you.name = "You";
            mery.name = "Mery";
            narrator.name = "Narrator";
        }
        public void SetUpHindi() {
            flowchart.SetStringVariable("Language", "Hindi");
            you.name = "आप";
            mery.name = "मेरी";
            narrator.name = "कथावाचक";
        }

        public string getSelectedLanguage() {
            return flowchart.GetStringVariable("Language");
        }
    }
}