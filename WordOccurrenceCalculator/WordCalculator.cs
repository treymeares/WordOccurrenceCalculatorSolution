using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace WordOccurrenceCalculator
{
    class WordCalculator
    {
        public static WordOccurrence[] CalculateOccurrences(ArrayList inputList)
        {
            
            WordOccurrence[] obj = new WordOccurrence[inputList.Count];
           
                for(int i = 0; i < inputList.Count; i++)
                {
                    obj[i] = new WordOccurrence();
                    obj[i].Word = inputList[i].ToString();

                //counting the occurrences of the word

                for (int j = 0; j < inputList.Count; j++)
                    {
                        String countWord = inputList[j].ToString();
                        if (obj[i].Word == countWord)
                            obj[i].Count++;
                    }
                }
                return obj;
            }
           
        }
    }

