using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DriveControlLibrary;

namespace LGiC5_Control
{
    public class Menu
    {
        int actualSectionIndex;
        int actualParamIndex;
        int numOfSections;
        string txtContent;
        Dictionary<string, Register[]> registerSections;
        public Menu(ref Dictionary<string, Register[]> registerSections)
        {
            this.registerSections = registerSections;
            numOfSections = this.registerSections.Count;
            actualSectionIndex = 0;
            actualParamIndex = 0;
        }
        public void secInc()
        {
            actualSectionIndex++;
            if (actualSectionIndex >= numOfSections) actualSectionIndex = 0;
            actualParamIndex = 0;
            updateDisplay();
            //KeyValuePair<string,Register[]> actualSection = registerSections.ElementAt(actualSectionIndex);
            //return actualSection.Value;
        }
        public void secDec()
        {
            actualSectionIndex--;
            if(actualSectionIndex < 0) actualSectionIndex = numOfSections-1;
            actualParamIndex = 0;
            updateDisplay();
            //KeyValuePair<string, Register[]> actualSection = registerSections.ElementAt(actualSectionIndex);
            //return actualSection.Value;
        }
        public string updateDisplay()
        {
            txtContent = registerSections.ElementAt(actualSectionIndex).Value[actualParamIndex].ToString();
            return txtContent;
        }
    }
}
