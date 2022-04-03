using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 Console.WriteLine("Enter a sentence : ");
            ArrayList vowelList = new ArrayList();
            char[] vowels = { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U','ö'};
            string letters = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(letters.Length); i++)
            {
                for (int j = 0; j < Convert.ToInt32(vowels.Length); j++)
                {
                    if (letters[i].Equals(vowels[j]))
                    {
                        vowelList.Add(letters[i]);
                        Console.WriteLine(letters[i]);
                    }
                }
            }
            
