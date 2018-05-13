using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace otherProblems
{
    class MostFrequentWord
    {   // Find most frquent words in text which is not most common words in English 
        public static void  Most(string st, int x) // out most top x frequent words ,
        {
            int[] temp = new int[x]; // hold frequencies of top X in descending order
            int swap;

            Hashtable te = new Hashtable(); // to hold most top x words frequency as key
            Hashtable words = new Hashtable(); // hold  all words with their frequncy 

           
            words = Words(st); // // GET WORDS WITH THEIR FREQUENCY 

            int i = 0; // to count distinct frequency of words 
            int j = 0; // counter where minimum word frequency stored 

            foreach (DictionaryEntry ent in words)  // sorting distinct top values in descending order
            {
                if (i == 0) // there is no any element at first , just add 
                {
                    te.Add(ent.Value, ent.Key); // key become frequency value 
                    temp[i] = (int)ent.Key;
                    i++;
                }
m                else 
                {
                      if (i < x)  // number of words get is less than number of words required
                         j = i; 
                      else
                        j = x; // index where the minimum frequency is stored 

                    if (!te.ContainsKey(ent.Value)) // to get distinct frequency , i hold number of distinct frequency 
                    {
                        if (i == j) // which means still we didn't pick x words , maximum words we want
                        {
                            temp[j] = (int)ent.Value;
                            te.Add(ent.Value, ent.Key);
                            i++;
                        }
                        else // we have x distinct words already   , now check the frequency of the current against already picked one
                        {
                            if ((int)ent.Value > temp[j]) 
                            {
                                te.Remove(temp[j]);// remove the most less frequent string 
                                te.Add(ent.Value, ent.Key);

                                temp[j] = (int)ent.Value;
                                i++;
                            }
                            else
                                j = -1; // don't check the array ,it is less than  with already checked one

                        }

                        while (j > 0) // using insertion to put the current into the right index , descending order
                             {

                                     if (temp[j - 1] < temp[j])
                                          {
                                              swap = temp[j];
                                              temp[j] = temp[j - 1];
                                              temp[j - 1] = swap;
                                               j--;

                                             }
                                      else
                                         break;
                            
                             }

                           

                    } 
                }

            }

            j = 0;

            while(j < te.Count)
            {
                swap = temp[j];
                Console.WriteLine(" Top frequent at rank {0} with frequncy {1} is {2}) ", j + 1, temp[j], te[swap]);
                j++;

            }




           
        }

        public static Hashtable Words(string st) // GET WORDS WITH THEIR FREQUENCY 
        {
            Hashtable word = new Hashtable();
            int tvalue;
            int sta = 0;// Index  for the beginning of the word
            int end = 0; // word separater found , 
            int i = 0; // counter for each character
            String  temp; // temporarly to store the word
            while (sta < st.Length)
            {
                if (st[sta] == ' ' || st[sta] == '&' || st[sta] == '(' || st[sta] == ')' || st[sta] == '.') 
                {
                    if (sta == end) // // beginning of the word ignore
                        sta = i + 1;
                    else // word separator
                    {
                        temp = st.Substring(sta, end - sta).ToUpper(); //
                         // you can have collection of all most common words in english in hash table and avoid considering them here 

                        if (temp == "THE" || temp == "IS" || temp == "WAS" || temp == "WERE" || temp == "IT" || temp == "A" || temp == "GOT" || temp == "GET") // if you found these words ignore
                        {
                            sta = i + 1;// word start with the next chharachter
                        }

                        else
                        {
                            if (word.ContainsKey(temp))
                            {
                                tvalue = (int)word[temp];
                                tvalue++;
                                word[temp] = tvalue;

                            }
                            else
                            {
                                word.Add(temp, 1);

                            }

                            sta = i + 1;
                        }


                    }
                }
                i++;
                end++;

            }


            return word;


        }
    }
}
